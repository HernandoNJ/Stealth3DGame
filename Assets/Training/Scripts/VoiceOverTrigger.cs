using Training.Scripts.Manager;
using UnityEngine;

namespace Training.Scripts
{
public class VoiceOverTrigger : MonoBehaviour
{
    public AudioClip voiceOverDialogue;
    public int counter;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player") || counter >= 1) return;
        counter++;
        AudioManager.Instance.PlayVoiceOver(voiceOverDialogue);
    }
}
}
