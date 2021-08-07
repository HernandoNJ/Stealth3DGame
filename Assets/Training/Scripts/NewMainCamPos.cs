using System;
using UnityEngine;

public class NewMainCamPos : MonoBehaviour
{
    public Transform camTrigger;
    public static event Action<Vector3> OnNewCamPos;
    
    private void Start()
    {
        SendNewCamPos();
        Debug.Log("Hi there");
        Camera.main.transform.position = camTrigger.position;
    }

    private void SendNewCamPos()
    {
        OnNewCamPos?.Invoke(transform.position);
    }
}
