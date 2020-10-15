using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PresentationControl : MonoBehaviour
{
   public GameObject[] panels;


    public PresentationData data;

    void Start()
    {
        activateTitleSlide();
        activateIndexMenu();
      
       
        //activateHeadingSlide(Topics.gameEngines);
    }

   

    int getIndex(PresentationPannel index)
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

    void activateVideo(VideoClips clips)
    {
        GameObject videoPannel = panels[getIndex(PresentationPannel.video)];
        VideoController controller = videoPannel.GetComponent<VideoController>();
        controller.videoToPlay = data.video[(int)clips];
        videoPannel.SetActive(true);        
    }


    void activateHeadingAudio(HeadingClip clips)
    {
        GameObject audioPannel = panels[getIndex(PresentationPannel.audio)];
        AudioController controller = audioPannel.GetComponent<AudioController>();
        controller.clip = data.headingClip[(int)clips];
        audioPannel.SetActive(true);
    }


    void activateIndexMenu()
    {

        activatePannel(getIndex(PresentationPannel.indexMenu));
    }
 

    void activateTitleSlide()
    {
        activatePannel(getIndex(PresentationPannel.slides));
        activatePannel(getIndex(PresentationPannel.titleSlide));
    }

    void activateHeadingSlide(Topics topics)
    {
        
        GameObject headingData = panels[getIndex(PresentationPannel.headingSlide)];
        HeadingDisplay display = headingData.GetComponent<HeadingDisplay>();
        display.heading = data.headings[(int)topics];

        activatePannel(getIndex(PresentationPannel.slides));
        headingData.SetActive(true);
        deActivatePannel(getIndex(PresentationPannel.titleSlide));

     
    }

    void activateContentSlide(Topics topics)
    {
        GameObject contentData = panels[getIndex(PresentationPannel.contentSlide)];      

        ContentDisplay display = contentData.GetComponent<ContentDisplay>();
        display.content = data.contents[(int)topics]; 

        activatePannel(getIndex(PresentationPannel.slides));
        contentData.SetActive(true);
        deActivatePannel(getIndex(PresentationPannel.titleSlide));
        deActivatePannel(getIndex(PresentationPannel.headingSlide));
    }

    public void gotoOverview()
    {
       
        activateHeadingSlide(Topics.overview);
        activateHeadingAudio(HeadingClip.overview);
    }

    public void gotoGameGenres()
    {
       
        activateHeadingSlide(Topics.gameGenres);
        activateHeadingAudio(HeadingClip.overview);
    }

    public void gotoGamePlatform()
    {
        
        activateHeadingSlide(Topics.gamePlatform);
        activateHeadingAudio(HeadingClip.overview);
    }

    public void gotoGameTypes()
    {
                 
       activateHeadingSlide(Topics.gameTypes);
        activateHeadingAudio(HeadingClip.overview);
    }

    public void gotoGameEngines()
    {
        
        activateHeadingSlide(Topics.gameEngines);
        activateHeadingAudio(HeadingClip.overview);
    }

    public void gotoRoles()
    {
        
        activateHeadingSlide(Topics.roles);
        activateHeadingAudio(HeadingClip.overview);
    }

    public void gotoDemo()
    {
       
        activateHeadingSlide(Topics.demo);
        activateHeadingAudio(HeadingClip.overview);
    }    

}
