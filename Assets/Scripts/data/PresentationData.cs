using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "data", menuName = "PresentationData")]
public class PresentationData : ScriptableObject
{   
    public Content[] contents;
    public Heading[] headings;
    public VideoClip[] video;
    public AudioClip[] headingClip;
    public AudioClip[] contentClip;

}
