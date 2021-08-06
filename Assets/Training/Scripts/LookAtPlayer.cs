using System;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform target;
    public Transform startPosition;

    private void Start()
    {
        transform.position = startPosition.position;
        transform.rotation = startPosition.rotation;
    }

    private void Update()
    {
        transform.LookAt(target);
    }
}
