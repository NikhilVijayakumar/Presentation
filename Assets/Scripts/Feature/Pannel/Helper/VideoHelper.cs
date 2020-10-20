using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Presentation.Video.Model;
using Presentation.Video.Controller;
using UnityEngine.Video;
using Presentation.Audio.Controller;


namespace Presentation.Pannel.Helper
{
    public class VideoHelper : BaseHelper
    {

        private VideoClip videoContent;
        private AudioClip contentClip;
        private AudioClip videoAudioClips;
        private AudioController.AudioFinished callback;

        public VideoHelper(GameObject videoPannel, GameObject contentAudio, AudioController.AudioFinished audioDelegate)
        {           
            pannel = videoPannel;
            audioPannel = contentAudio;           
            callback = audioDelegate;
        }

        public void setVideo(VideoClip video, AudioClip audio, AudioClip content)
        {
            videoContent = video;
            videoAudioClips = audio;
            contentClip = content;
        }


        public void activate()
        {
           
            VideoController controller = pannel.GetComponent<VideoController>();
            controller.videoContent = videoContent;
            controller.audioContent = videoAudioClips;
            ActivatePannel();
            activateContentAudio();
        }

        private void activateContentAudio()
        {
            AudioController controller = audioPannel.GetComponent<AudioController>();
            controller.clip = contentClip;
            controller.isAdded = true;
            controller.volume = 3.5f;
            controller.finished = callback;
            ActivateAudioPannel();
        }

        public void deActivate()
        {            
            deActivatePannel();
            deActivateAudioPannel();
        }

    }
}
