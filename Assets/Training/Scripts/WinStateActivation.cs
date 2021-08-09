using UnityEngine;

namespace Training.Scripts
{
public class WinStateActivation : MonoBehaviour
{
    public GameObject winCutscene;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if(GameManager.Instance.hasCard) winCutscene.SetActive(true);
        else Debug.Log("Grab the key");
    }
}
}
