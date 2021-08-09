using UnityEngine;

namespace Training.Scripts
{
[RequireComponent(typeof(AudioManager))]
public class AudioManager : MonoBehaviour
{
   private static AudioManager _instance;
   public static AudioManager Instance
   { get { if(_instance == null) Debug.Log("AudioManager is null"); return _instance; }}

   public AudioSource VoiceOverAudioSource;
   public int counter;
   
   private void Awake()
   {
      _instance = this;
   }

   public void PlayVoiceOver(AudioClip clipArg)
   {
      counter++;
      VoiceOverAudioSource.clip = clipArg;
      if(counter ==1) VoiceOverAudioSource.Play();
   }
}
}
