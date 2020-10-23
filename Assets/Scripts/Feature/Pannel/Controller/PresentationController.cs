using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Presentation.Content.Model;
using Presentation.Audio.Controller;
using Presentation.Content.View;
using Presentation.Heading.Model;
using Presentation.Heading.View;
using Presentation.Video.Model;
using Presentation.Video.Controller;
using Presentation.Pannel.Model;
using Presentation.Pannel.Manager;
using Presentation.Pannel.Helper;
using System.ComponentModel;

namespace Presentation.Pannel.Controller
{
    public class PresentationController : MonoBehaviour
    {
        public GameObject[] panels;
        public PresentationModel data;
        private bool isContentCompleted;
        private DataManager manager;

        private TitleHelper titleHelper;
        private MenuHelper menuHelper;
        private HeadingHelper headingHelper;
        private ContentHelper contentHelper;
        private VideoHelper videoHelper;

        void Start()
        {
            InitData();
            ActivateInitialSlides();
           
            //activateVideo(VideoClips.CyberPunk);
           
        }
        private void InitData()
        {
            manager = new DataManager();
            titleHelper = new TitleHelper(getPannel(PannelModel.slides), getPannel(PannelModel.titleSlide)); 
            menuHelper = new MenuHelper(getPannel(PannelModel.indexMenu));
            headingHelper = new HeadingHelper(getPannel(PannelModel.slides), getPannel(PannelModel.headingSlide), getPannel(PannelModel.audio), onAudioFinished);
            contentHelper = new ContentHelper(getPannel(PannelModel.slides), getPannel(PannelModel.contentSlide), getPannel(PannelModel.audio), onAudioFinished,onContentCompleted);
            videoHelper = new VideoHelper(getPannel(PannelModel.video), getPannel(PannelModel.audio), onAudioFinished);
        }

        private void ActivateInitialSlides()
        {
            activateIndexMenu();
            activateTitleSlide();
            
        }

        private void deActivateAll()
        {
            titleHelper.deActivate();
           // menuHelper.deActivate();
            headingHelper.deActivate();
            contentHelper.deActivate();
            videoHelper.deActivate();
        }


        private GameObject getPannel(PannelModel pannelName)
        {
            return panels[(int)pannelName];
        }

        void activateIndexMenu()
        {            
            menuHelper.activate();
        }


        void activateTitleSlide()
        {
            isContentCompleted = true;
            deActivateAll();
            titleHelper.activate();
        }

        void activateHeadingSlide(Topics topics)
        {
            isContentCompleted = true;
            deActivateAll();
            headingHelper.setHeading(data.headings[(int)topics], data.headingClip[(int)manager.getHeadingClipFromTopic(topics)]);
            headingHelper.activate();            
        }
        

        void activateContentSlide(Topics topics)
        {
            isContentCompleted = false;
            deActivateAll();
            contentHelper.setContent(data.contents[(int)topics], data.contentClip[(int)manager.getContentClipFromTopic(topics)]);
            contentHelper.activate();
        }
    
        void activateVideo(VideoClips clips)
        {
            isContentCompleted = true;
            deActivateAll();
            videoHelper.setVideo(data.video[(int)clips], data.videoAudioClips[(int)manager.getVideoAudioClip(clips)], data.videoContentAudio[(int)manager.getVideoTopics()]);
            videoHelper.activate();
        }


        void onAudioFinished()
        {
            if (isContentCompleted)
            {
                SlideModel type = manager.getSlideType();
                if (type == SlideModel.Heading)
                {
                    activateHeadingSlide(manager.getNextTopic());
                }
                else if (type == SlideModel.Content)
                {
                    activateContentSlide(manager.getNextTopic());
                }
                else if (type == SlideModel.Video)
                {
                    activateVideo(manager.getNextVideoClips());
                }
                else
                {
                    deActivateAll();
                    headingHelper.activateThankyou(data.headings[6]);                   
                }
            }
        }


        void onContentCompleted()
        {
            isContentCompleted = true;
            onAudioFinished();
        }

        public void gotoOverview()
        {           
            activateHeadingSlide(Topics.Overview);

        }

        public void gotoGameGenres()
        {
            activateHeadingSlide(Topics.GameGenres);

        }

        public void gotoGamePlatform()
        {

            activateHeadingSlide(Topics.GamePlatform);
        }

        public void gotoGameTypes()
        {

            activateHeadingSlide(Topics.GameTypes);
        }

        public void gotoGameEngines()
        {

            activateHeadingSlide(Topics.GameEngines);
        }       

        public void gotoDemo()
        {
            activateHeadingSlide(Topics.Demo1);
        }

    }
}
