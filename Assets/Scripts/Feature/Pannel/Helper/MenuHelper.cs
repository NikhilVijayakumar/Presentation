using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation.Pannel.Helper
{
    public class MenuHelper : BaseHelper
    {
        public MenuHelper(GameObject menu)
        {
            pannel = menu;
        }

        public void activate()
        {
            ActivatePannel();
        }

        public void deActivate()
        {
            deActivatePannel();
        }

    }
}

