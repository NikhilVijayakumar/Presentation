using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Presentation.Content.Model;
using Presentation.Heading.Model;
using Presentation.Pannel.Model;

namespace Presentation.Pannel.Manager
{
    public class SlideManager
    {

        private ControlManager manager;

        public SlideManager(ControlManager controlManager)
        {
            manager = controlManager;
        }

        public HeadingAudio getHeadingClipFromTopic(Topics topic)
        {
            switch ((int)topic)
            {
                case 0:
                    manager.setControlFlow(ControlFlowModel.OverviewHeading);
                    return HeadingAudio.overview;
                case 1:
                    manager.setControlFlow(ControlFlowModel.GameGenresHeading);
                    return HeadingAudio.gameGenres;
                case 2:
                    manager.setControlFlow(ControlFlowModel.GamePlatformHeading);
                    return HeadingAudio.gamePlatform;
                case 3:
                    manager.setControlFlow(ControlFlowModel.GameTypesHeading);
                    return HeadingAudio.gameTypes;
                case 4:
                    manager.setControlFlow(ControlFlowModel.GameEnginesHeading);
                    return HeadingAudio.gameEngines;
                case 5:
                    manager.setControlFlow(ControlFlowModel.DemoHeading);
                    return HeadingAudio.roles;              
                default:
                    manager.setControlFlow(ControlFlowModel.OverviewHeading);
                    return HeadingAudio.overview;
            }
        }

        public ContentAudio getContentClipFromTopic(Topics topic)
        {
            switch ((int)topic)
            {
                case 0:
                    manager.setControlFlow(ControlFlowModel.OverviewContent);
                    return ContentAudio.overview;
                case 1:
                    manager.setControlFlow(ControlFlowModel.GameGenresContent);
                    return ContentAudio.gameGenres;
                case 2:
                    manager.setControlFlow(ControlFlowModel.GamePlatformContent);
                    return ContentAudio.gamePlatform;
                case 3:
                    manager.setControlFlow(ControlFlowModel.GameTypesContent);
                    return ContentAudio.gameTypes;
                case 4:
                    manager.setControlFlow(ControlFlowModel.GameEnginesContent);
                    return ContentAudio.gameEngines;
                case 5:
                    manager.setControlFlow(ControlFlowModel.DemoContent1);
                    return ContentAudio.demo;
                case 6:
                    manager.setControlFlow(ControlFlowModel.DemoContent2);
                    return ContentAudio.demo;
                case 7:
                    manager.setControlFlow(ControlFlowModel.DemoContent3);
                    return ContentAudio.demo;
                default:
                    manager.setControlFlow(ControlFlowModel.OverviewContent);
                    return ContentAudio.overview;
            }
        }
    }
}

