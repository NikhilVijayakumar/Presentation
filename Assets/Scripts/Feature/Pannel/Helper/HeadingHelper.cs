using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Presentation.Heading.Model;
using Presentation.Heading.View;
using Presentation.Audio.Controller;



namespace Presentation.Pannel.Helper
{
    public class HeadingHelper : BaseHelper
    {
       
        private HeadingModel headingData;
        private AudioClip headingAudio;
        private AudioController.AudioFinished callback;


        public HeadingHelper(GameObject slide,GameObject headingPannel, GameObject headingAudio, AudioController.AudioFinished audioDelegate) 
        {
            pannel = headingPannel;
            audioPannel = headingAudio;
            slidePannel = slide;
            callback = audioDelegate;
        }

        public void setHeading(HeadingModel data, AudioClip audio)
        {
            headingData = data;
            headingAudio = audio;
           
        }       

        public void activate()
        {
            HeadingView view = pannel.GetComponent<HeadingView>();
            view.heading = headingData;
            ActivateSlide();
            ActivatePannel();
            activateHeadingAudio();
        }

        public void activateThankyou(HeadingModel data)
        {
            HeadingView view = pannel.GetComponent<HeadingView>();
            view.heading = data;
            ActivateSlide();
            ActivatePannel();
            //activateHeadingAudio();
        }

        private void activateHeadingAudio()
        {            
            AudioController controller = audioPannel.GetComponent<AudioController>();
            controller.clip = headingAudio;
            controller.isAdded = true;
            controller.volume = 4f;
            controller.finished = callback;
            ActivateAudioPannel();
        }

        public void deActivate()
        {
            deActivateSlide();
            deActivatePannel();
            deActivateAudioPannel();
        }

    }
}


