using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Presentation.Video.Model;
using Presentation.Pannel.Model;

namespace Presentation.Pannel.Manager
{
    public class VideoManager
    {
        private ControlManager manager;

        public VideoManager(ControlManager controlManager)
        {
            manager = controlManager;
        }

        public VideoClips getVideo(VideoTopics topic)
        {         
            switch ((int)topic)
            {
                case 0:                  
                    manager.setControlFlow(ControlFlowModel.OverviewVideo);
                    return VideoClips.CyberPunk;
                case 1:
                   
                    manager.setControlFlow(ControlFlowModel.GameGenresVideoAction);
                    return VideoClips.CallOfDuty; 
                case 2:
                    manager.setControlFlow(ControlFlowModel.GameGenresVideoAdventure);
                    return VideoClips.AssasisCreed;
                case 3:
                    manager.setControlFlow(ControlFlowModel.GameGenresVideoRolePlay);
                    return VideoClips.Witcher;
                case 4:
                    manager.setControlFlow(ControlFlowModel.GameGenresVideoSimulation);
                    return VideoClips.FlightSimulator;
                case 5:
                    manager.setControlFlow(ControlFlowModel.GameGenresVideoStrategy);
                    return VideoClips.Civilization6;
                case 6:
                    manager.setControlFlow(ControlFlowModel.GamePlatformVideo);
                    return VideoClips.FarCry6;
                case 7:
                    manager.setControlFlow(ControlFlowModel.GameTypesVideo2d);
                    return VideoClips.Contra;
                case 8:
                    manager.setControlFlow(ControlFlowModel.GameTypesVideo3d);
                    return VideoClips.GTA6;
                case 9:
                    manager.setControlFlow(ControlFlowModel.GameEnginesVideo);
                    return VideoClips.FarCry6;
                default:
                    manager.setControlFlow(ControlFlowModel.OverviewVideo);
                    return VideoClips.GTA6;
            }
        }


        public VideoAudioClips getVideoAudioClip(VideoClips clips)
        {
            switch ((int)clips)
            {
                case 0:
                    return VideoAudioClips.AgeOfEmpires;
                case 1:
                    return VideoAudioClips.AssasisCreed;
                case 2:
                    return VideoAudioClips.CallOfDuty;
                case 3:
                    return VideoAudioClips.Civilization6;
                case 4:
                    return VideoAudioClips.None;
                case 5:
                    return VideoAudioClips.CyberPunk;
                case 6:
                    return VideoAudioClips.FarCry6;
                case 7:
                    return VideoAudioClips.FlightSimulator;
                case 8:
                    return VideoAudioClips.GTA6;
                case 9:
                    return VideoAudioClips.None;
                case 10:
                    return VideoAudioClips.Witcher;
                default:
                    return VideoAudioClips.None;
            }
        }
    }
}


