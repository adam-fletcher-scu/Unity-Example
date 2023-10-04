using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    public AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleSound()
    {
        if(audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }
}
