using UnityEngine;

public class Detector : MonoBehaviour
{
    public GameObject gameOverScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverScene.SetActive(true);
        }
    }
}
