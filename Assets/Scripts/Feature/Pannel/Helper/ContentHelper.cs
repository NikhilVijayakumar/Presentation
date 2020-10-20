using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Presentation.Content.Model;
using Presentation.Audio.Controller;
using Presentation.Content.View;

namespace Presentation.Pannel.Helper
{
    public class ContentHelper : BaseHelper
    {
        private ContentModel contentData;
        private AudioClip contentAudio;
        private AudioController.AudioFinished callback;
        private ContentView.ContentCompleted onContentCompleted;


        public ContentHelper(GameObject slide, GameObject contentPannel, GameObject contentAudio, AudioController.AudioFinished audioDelegate, ContentView.ContentCompleted contentDeligate)
        {
            pannel = contentPannel;
            audioPannel = contentAudio;
            slidePannel = slide;
            callback = audioDelegate;
            onContentCompleted = contentDeligate;
        }

        public void setContent(ContentModel data, AudioClip audio)
        {
            contentData = data;
            contentAudio = audio;           
        }

        public void activate()
        {
            ContentView view = pannel.GetComponent<ContentView>();
            view.content = contentData;
            view.completed = onContentCompleted;
            ActivateSlide();
            ActivatePannel();
            activateContentAudio();
        }

        private void activateContentAudio()
        {
            AudioController controller = audioPannel.GetComponent<AudioController>();
            controller.clip = contentAudio;
            controller.isAdded = true;
            controller.volume = 2f;
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

