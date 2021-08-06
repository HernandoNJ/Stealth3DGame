using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Animator))]
public class GuardAI : MonoBehaviour
{
    public List<Transform> waypoints;
    private NavMeshAgent guardAgent;
    private Animator animator;
    [SerializeField] private Transform newPoint;
    [SerializeField] private float distance;
    [SerializeField] private int currentTarget;
    [SerializeField] private bool reverse;
    [SerializeField] private bool stopMove;
    [SerializeField] private bool targetReached;
    [SerializeField] private bool isFinalPoint;


    private void Start()
    {
        guardAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        animator.SetBool("isWalking",true);
    }

    private void Update()
    {
        MoveToPoint();
    }

    private void MoveToPoint()
    {
        newPoint = waypoints[index: currentTarget];

        if (waypoints.Count > 0 && newPoint != null && !stopMove)
        {
            guardAgent.SetDestination(target: newPoint.position);
            var a = Vector3.Distance(a: guardAgent.nextPosition, b: transform.position);
        }

        CheckDistance();
    }

    private void CheckDistance()
    {
        distance = Vector3.Distance(transform.position, newPoint.position);

        if (distance > 1.0f)
        {
            targetReached = false;
        }
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
            reverse = true;
            StartCoroutine(routine: WaitToMove());
        }
        else if (currentTarget == 0)
        {
            reverse = false;
            StartCoroutine(routine: WaitToMove());
        }

        if (reverse) currentTarget--;
        else currentTarget++;
    }

    private IEnumerator WaitToMove()
    {
        stopMove = true;
        animator.SetBool("isWalking",false);
        var randNum = Random.Range(2f, 4f);
        yield return new WaitForSeconds(randNum);
        stopMove = false;
        animator.SetBool("isWalking",true);

    }
}
