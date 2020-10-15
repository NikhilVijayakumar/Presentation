using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume;

    void Start()
    {
        audioSource.PlayOneShot(clip, volume);
    }

   
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(clip, volume);
        }
    }
}
