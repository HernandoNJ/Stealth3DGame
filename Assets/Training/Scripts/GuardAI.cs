using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class GuardAI : MonoBehaviour
{
    public List<Transform> waypoints;
    private NavMeshAgent guardAgent;
    [SerializeField] private Transform newPoint;
    [SerializeField] private float distance;
    [SerializeField] private int currentTarget;
    [SerializeField] private bool reverse;
    [SerializeField] private bool stopMove;
    [SerializeField] private bool targetReached;


    private void Start()
    {
        guardAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        MoveToPoint();
    }

    private void MoveToPoint()
    {
        newPoint = waypoints[currentTarget];

        if (waypoints.Count > 0 && newPoint != null && !stopMove) { guardAgent.SetDestination(newPoint.position); }

        CheckDistance();
    }

    private void CheckDistance()
    {
        distance = Vector3.Distance(transform.position, newPoint.position);

        if (distance > 1.0f) targetReached = false;
        else if (!targetReached)
        {
            targetReached = true;
            NextPoint();
        }
    }

    private void NextPoint()
    {
        if (currentTarget == waypoints.Count - 1)
        {
            reverse = true; stopMove = true;
            StartCoroutine(WaitToMove());
        }
        else if (currentTarget == 0)
        {
            reverse = false; stopMove = true;
            StartCoroutine(WaitToMove());
        }

        if (reverse) currentTarget--;
        else currentTarget++;
    }

    private IEnumerator WaitToMove()
    {
        var randNum = Random.Range(0.5f, 2f);
        yield return new WaitForSeconds(randNum);
        stopMove = false;
    }
}
