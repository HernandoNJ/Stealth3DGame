using System;
using Cinemachine;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform target;
    public Transform startPosition;
    public CinemachineBrain cinem;

    private void OnEnable()
    {
        NewMainCamPos.OnNewCamPos += SetCamPos;
    }

    private void Start()
    {
        cinem = GetComponent<CinemachineBrain>();
        transform.position = startPosition.position;
        transform.rotation = startPosition.rotation;
    }

    private void Update()
    {
        transform.LookAt(target); 
    }

    private void SetCamPos(Vector3 pos)
    {
        // The problem is not the cinemachine brain, but the last cam position that was set by it.
        // The solution is to set a new cam pos with an event
        cinem.enabled = false;
        //cinem.enabled = true;
        //transform.position = pos;
        Debug.Log(transform.position);
    }
}
