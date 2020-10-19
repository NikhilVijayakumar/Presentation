using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Presentation.Pannel.Model;
using Presentation.Video.Model;

namespace Presentation.Pannel.Manager
{
    public class ControlManager
    {
        private ControlFlowModel controlFlow;
        private Topics nextTopic;
        private VideoTopics videoTopics;

        public void setControlFlow(ControlFlowModel flow)
        {
            controlFlow = flow;
        }

        public Topics getNextTopic()
        {
            return nextTopic;
        }

        public VideoTopics getNextVideoTopics()
        {
            return videoTopics;
        }

        public SlideModel getSlideType()
        {   
     
            switch ((int)controlFlow + 1)
            {
                case 0:
                    nextTopic = Topics.Overview;
                    return SlideModel.Heading;
                case 1:
                    nextTopic = Topics.Overview;
                    return SlideModel.Content;
                case 2:
                    videoTopics = VideoTopics.OverviewVideo;
                    return SlideModel.Video;
                case 3:
                    nextTopic = Topics.GameGenres;
                    return SlideModel.Heading;
                case 4:
                    nextTopic = Topics.GameGenres;
                    return SlideModel.Content;
                case 5:
                    videoTopics = VideoTopics.GameGenresVideoAction;
                    return SlideModel.Video;
                case 6:
                    videoTopics = VideoTopics.GameGenresVideoAdventure;
                    return SlideModel.Video;
                case 7:
                    videoTopics = VideoTopics.GameGenresVideoRolePlay;
                    return SlideModel.Video;
                case 8:
                    videoTopics = VideoTopics.GameGenresVideoSimulation;
                    return SlideModel.Video;
                case 9:
                    videoTopics = VideoTopics.GameGenresVideoStrategy;
                    return SlideModel.Video;
                case 10:
                    nextTopic = Topics.GamePlatform;
                    return SlideModel.Heading;
                case 11:
                    nextTopic = Topics.GamePlatform;
                    return SlideModel.Content;
                case 12:
                    videoTopics = VideoTopics.GamePlatformVideo;
                    return SlideModel.Video;
                case 13:
                    nextTopic = Topics.GameTypes;
                    return SlideModel.Heading;
                case 14:
                    nextTopic = Topics.GameTypes;
                    return SlideModel.Content;
                case 15:
                    videoTopics = VideoTopics.GameTypesVideo;
                    return SlideModel.Video;
                case 16:
                    nextTopic = Topics.GameEngines;
                    return SlideModel.Heading;
                case 17:
                    nextTopic = Topics.GameEngines;
                    return SlideModel.Content;
                case 18:
                    videoTopics = VideoTopics.GameEnginesVideo;
                    return SlideModel.Heading;
                case 19:
                    nextTopic = Topics.Demo1;
                    return SlideModel.Heading;
                case 20:
                    nextTopic = Topics.Demo1;
                    return SlideModel.Content;
                case 21:
                    nextTopic = Topics.Demo1;
                    return SlideModel.Content;
                case 22:
                    nextTopic = Topics.Demo1;
                    return SlideModel.Video;
                default:
                    nextTopic = Topics.Finish;
                    return SlideModel.None;
            }
        }

    }
}

