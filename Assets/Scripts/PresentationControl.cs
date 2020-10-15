using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentationControl : MonoBehaviour
{
    public GameObject[] panels;
    public Content[] contents;
    public Heading[] headings;
    void Start()
    {
        activateHeadingSlide(Topics.gameEngines);
       activateIndexMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
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

    void activateVideo()
    {
        activatePannel(getIndex(PresentationPannel.video));
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
        display.heading = headings[(int)topics];

        activatePannel(getIndex(PresentationPannel.slides));
        headingData.SetActive(true);
        deActivatePannel(getIndex(PresentationPannel.titleSlide));
    }

    void activateContentSlide(Topics topics)
    {
        GameObject contentData = panels[getIndex(PresentationPannel.contentSlide)];      

        ContentDisplay display = contentData.GetComponent<ContentDisplay>();
        display.content = contents[(int)topics]; 

        activatePannel(getIndex(PresentationPannel.slides));
        contentData.SetActive(true);
        deActivatePannel(getIndex(PresentationPannel.titleSlide));
        deActivatePannel(getIndex(PresentationPannel.headingSlide));
    }


}

public enum PresentationPannel
{
    video = 0,
    indexMenu = 1,
    slides = 2,
    titleSlide = 3,
    headingSlide = 4,
    contentSlide = 5
}

public enum Topics
{
    overview = 0,
    gameGenres = 1,
    gamePlatform = 2,
    gameTypes = 3,
    gameEngines = 4
}
