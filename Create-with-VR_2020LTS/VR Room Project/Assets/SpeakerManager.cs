using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerManager : MonoBehaviour
{
    [SerializeField]private AudioSource speakerAudio;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if(speakerAudio.isPlaying == true)
            {
                speakerAudio.Pause();
            }
            else
            {
                speakerAudio.UnPause();
            }
        }
    }
}
