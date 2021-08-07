using UnityEngine;

public class CameraLookAtUpdater : MonoBehaviour
{

    public Transform currentCamera;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        Camera.main.transform.position = currentCamera.position;
        Camera.main.transform.rotation = currentCamera.rotation;
    }
}
