using UnityEngine;

namespace Training.Scripts
{
public class VoiceOverTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public int clipCounter;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (clipCounter >= 1 || !other.CompareTag("Player")) return;
        audioSource.Play();
        clipCounter++;
    }
}
}
