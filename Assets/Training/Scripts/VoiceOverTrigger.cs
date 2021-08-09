using UnityEngine;

namespace Training.Scripts
{
public class VoiceOverTrigger : MonoBehaviour
{
    public AudioClip coinDialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        AudioManager.Instance.PlayVoiceOver(coinDialogue);
    }
}
}
