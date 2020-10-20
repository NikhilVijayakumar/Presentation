using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation.Audio.Controller
{
    public class AudioController : MonoBehaviour
    {
        public delegate void AudioFinished();
        public AudioSource audioSource;
        public AudioClip clip;
        public float volume;
        public bool isAdded;
        public AudioFinished finished;
        private bool isFinished = false;


        void Start()
        {
            //  audioSource.PlayOneShot(clip, volume);
        }


        void Update()
        {

            if (!audioSource.isPlaying && isAdded)
            {
                isFinished = false;
                isAdded = false;
                audioSource.PlayOneShot(clip, volume);
            }
            else if (!audioSource.isPlaying && !isFinished)
            {
                isFinished = true;
                finished();
            }
        }
    }
}


