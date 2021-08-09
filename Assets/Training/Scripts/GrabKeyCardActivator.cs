using UnityEngine;

namespace Training.Scripts
{
public class GrabKeyCardActivator : MonoBehaviour
{
    public GameObject sleepingGuardCutscene;

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")) return;
        sleepingGuardCutscene.SetActive(true);
        GameManager.Instance.hasCard = true;
    }
}
}
