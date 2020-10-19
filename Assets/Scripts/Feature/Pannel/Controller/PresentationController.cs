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


namespace Presentation.Pannel.Controller
{
    public class PresentationController : MonoBehaviour
    {
        public GameObject[] panels;
        public PresentationModel data;
        private bool isContentCompleted;
        private DataManager manager;

        void Start()
        {
            manager = new DataManager();
            activateTitleSlide();
            activateIndexMenu();
            // activateVideo(VideoClips.CyberPunk);
            // activateHeadingAudio(HeadingClip.overview);
        }

        int getIndex(PannelModel index)
        {
            return (int)index;
        }


        void activatePannel(int index)
        {
            panels[index].SetActive(true);
        }

        void deActivatePannel(int index)
        {
            panels[index].SetActive(false);
        }
   


        void activateIndexMenu()
        {
            activatePannel(getIndex(PannelModel.indexMenu));
        }


        void activateTitleSlide()
        {
            isContentCompleted = true;
            activatePannel(getIndex(PannelModel.slides));
            activatePannel(getIndex(PannelModel.titleSlide));
        }

        void activateHeadingSlide(Topics topics)
        {
            isContentCompleted = true;
            GameObject headingData = panels[getIndex(PannelModel.headingSlide)];
            HeadingView display = headingData.GetComponent<HeadingView>();
            display.heading = data.headings[(int)topics];
            activatePannel(getIndex(PannelModel.slides));
            headingData.SetActive(true);
            deActivatePannel(getIndex(PannelModel.titleSlide));
            deActivatePannel(getIndex(PannelModel.contentSlide));
            activateHeadingAudio(manager.getHeadingClipFromTopic(topics));
        }

        void activateHeadingAudio(HeadingAudio clips)
        {
            GameObject audioPannel = panels[getIndex(PannelModel.audio)];
            AudioController controller = audioPannel.GetComponent<AudioController>();
            controller.clip = data.headingClip[(int)clips];
            controller.isAdded = true;
            controller.finished = onAudioFinished;
            audioPannel.SetActive(true);
        }

        void activateContentSlide(Topics topics)
        {
            isContentCompleted = false;
            GameObject contentData = panels[getIndex(PannelModel.contentSlide)];
            ContentView display = contentData.GetComponent<ContentView>();
            display.content = data.contents[(int)topics];
            display.completed = onContentCompleted;
            activatePannel(getIndex(PannelModel.slides));
            contentData.SetActive(true);
            deActivatePannel(getIndex(PannelModel.titleSlide));
            deActivatePannel(getIndex(PannelModel.headingSlide));
            activateContentAudio(manager.getContentClipFromTopic(topics));
        }

        void activateContentAudio(ContentAudio clips)
        {
            GameObject audioPannel = panels[getIndex(PannelModel.audio)];
            AudioController controller = audioPannel.GetComponent<AudioController>();
            controller.clip = data.contentClip[(int)clips];
            controller.isAdded = true;
            controller.finished = onAudioFinished;
            audioPannel.SetActive(true);
        }

        void activateVideo(VideoClips clips)
        {
            GameObject videoPannel = panels[getIndex(PannelModel.video)];
            VideoController controller = videoPannel.GetComponent<VideoController>();
            controller.video = data.video[(int)clips];
            controller.audio = data.videoAudioClips[(int)manager.getVideoAudioClip(clips)];
            videoPannel.SetActive(true);
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

                }
                else
                {

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
            print("gotoOverview");
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
