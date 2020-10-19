using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Presentation.Content.Model;
using Presentation.Heading.Model;

namespace Presentation.Pannel.Model
{
    [CreateAssetMenu(fileName = "data", menuName = "PresentationData")]
    public class PresentationModel : ScriptableObject
    {
        public ContentModel[] contents;
        public HeadingModel[] headings;
        public VideoClip[] video;
        public AudioClip[] headingClip;
        public AudioClip[] contentClip;
        public AudioClip[] videoAudioClips;

    }
}



