using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation.Pannel.Helper
{
    public class BaseHelper
    {
        protected GameObject pannel;
        protected GameObject audioPannel;
        protected GameObject slidePannel;


        protected void deActivateSlide()
        {
            slidePannel.SetActive(false);
        }

        protected void ActivateSlide()
        {
            slidePannel.SetActive(true);
        }



        protected void deActivatePannel()
        {
            pannel.SetActive(false);
        }

        protected void ActivatePannel()
        {
            pannel.SetActive(true);
        }


        protected void deActivateAudioPannel()
        {
            audioPannel.SetActive(false);
        }

        protected void ActivateAudioPannel()
        {
            audioPannel.SetActive(true);
        }




    }
}
