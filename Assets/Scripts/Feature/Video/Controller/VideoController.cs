using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Presentation.Video.Controller
{
    public class VideoController : MonoBehaviour
    {
        public RawImage image;
        public VideoClip videoContent;
        public AudioClip audioContent;
        public AudioSource audioSource;

        public VideoPlayer videoPlayer;
        //public VideoSource videoSource;



        void Start()
        {
            audioSource.clip = audioContent;
            Application.runInBackground = true;
            StartCoroutine(playVideo());
        }

        void Update()
        {
            Application.runInBackground = true;
            StartCoroutine(playVideo());
        }

        IEnumerator playVideo()
        {
            videoPlayer.playOnAwake = false;
            audioSource.playOnAwake = false;
           // audioSource.volume = 1.0f;
           // audioSource.volume = 1.0f;
            videoPlayer.source = VideoSource.VideoClip;
          //  videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
           //videoPlayer.EnableAudioTrack(0, true);
            //videoPlayer.SetTargetAudioSource(0, audioSource);
            videoPlayer.clip = videoContent;
            videoPlayer.Prepare();
            while (!videoPlayer.isPrepared)
            {
                yield return null;
            }
            image.texture = videoPlayer.texture;
            videoPlayer.Play();

            //audioSource.clip = audioContent;
            //audioSource.Play();
            audioSource.PlayOneShot(audioContent, 0.1f);
            audioSource.volume = 0.07f;
            while (videoPlayer.isPlaying)
            {
                yield return null;
            }
        }
    }
}

