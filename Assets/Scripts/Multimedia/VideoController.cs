using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public RawImage image;   
    public VideoClip videoToPlay;

    public VideoPlayer videoPlayer;
    //public VideoSource videoSource;



    void Start()
    {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
    }

    void Update()
    {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
    }

    IEnumerator playVideo()
    {       
        videoPlayer.playOnAwake = false;         
       // videoPlayer.source = VideoSource.VideoClip;       
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;      
        videoPlayer.EnableAudioTrack(0, true);    
        videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();
        while (!videoPlayer.isPrepared)
        {           
            yield return null;
        }
        image.texture = videoPlayer.texture;
        videoPlayer.Play();
        while (videoPlayer.isPlaying)
        {
              yield return null;
        }      
    }
}
