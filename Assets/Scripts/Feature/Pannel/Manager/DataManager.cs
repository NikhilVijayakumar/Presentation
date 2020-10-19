using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Presentation.Content.Model;
using Presentation.Heading.Model;
using Presentation.Video.Model;
using Presentation.Pannel.Model;

namespace Presentation.Pannel.Manager
{
    public class DataManager
    {

        private VideoManager videoManager;
        private SlideManager slideManager;
        private ControlManager controlManager;

        public DataManager()
        {
            controlManager = new ControlManager();
            slideManager = new SlideManager(controlManager);
            videoManager = new VideoManager(controlManager);

        }

        public Topics getNextTopic()
        {
            return controlManager.getNextTopic(); ;
        }



        public HeadingAudio getHeadingClipFromTopic(Topics topic)
        {
            return slideManager.getHeadingClipFromTopic(topic);
        }


        public ContentAudio getContentClipFromTopic(Topics topic)
        {
            return slideManager.getContentClipFromTopic(topic);
        }


        public SlideModel getSlideType()
        {
            return controlManager.getSlideType();
        }


        public VideoAudioClips getVideoAudioClip(VideoClips clips)
        {
            return videoManager.getVideoAudioClip(clips);
        }
    }
}

