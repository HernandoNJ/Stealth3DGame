using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound;
    
    private void Start()
    {
        AudioSource.PlayClipAtPoint(coinSound, Camera.main.transform.position);
    }
}
