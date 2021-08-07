using UnityEngine;

namespace Training.Scripts
{
public class Detector : MonoBehaviour
{
    public GameObject gameOverScene;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        gameOverScene.SetActive(true);
    }
}
}
