using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation.Pannel.Helper
{
    public class TitleHelper : BaseHelper
    {

        public TitleHelper(GameObject slide, GameObject titlePannel)
        {
            pannel = titlePannel;
            slidePannel = slide;
        }

        public void activate()
        {
            ActivateSlide();
            ActivatePannel();
        }

        public void deActivate()
        {
            deActivateSlide();
            deActivatePannel();
        }
    }
}

