using UnityEngine;
using UnityEngine.Serialization;

namespace Training.Scripts
{
public class VoiceOverTrigger : MonoBehaviour
{
    [FormerlySerializedAs("coinDialogue")]
    public AudioClip voiceOverDialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        AudioManager.Instance.PlayVoiceOver(voiceOverDialogue);
    }
}
}
