using UnityEngine;

public class CameraTrigger : MonoBehaviour
{

    public Transform currentCamera;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.main.transform.position = currentCamera.position;
            Camera.main.transform.rotation = currentCamera.rotation;
            Debug.Log(gameObject.name);
            
        }
    }
}
