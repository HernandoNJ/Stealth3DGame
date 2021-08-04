using UnityEngine;
using UnityEngine.AI;

namespace Training
{
public class Player : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    private Vector3 destination;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                agent.SetDestination(hitInfo.point); 
                animator.SetBool("Walk",true);
                destination = hitInfo.point;
            }
        }
        
        var newDistance = Vector3.Distance(transform.position, destination);
        if(newDistance < 1.5f) animator.SetBool("Walk",false);

    }
}
}
