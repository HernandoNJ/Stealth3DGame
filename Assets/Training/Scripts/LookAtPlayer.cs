using System;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        transform.LookAt(target);
    }
}
