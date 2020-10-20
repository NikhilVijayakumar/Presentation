using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation.Menu.View
{
    public class IndexMenuView : MonoBehaviour
    {
        public GameObject PanelMenu;

        public void ShowHideMenu()
        {
            if (PanelMenu != null)
            {
                Animator animator = PanelMenu.GetComponent<Animator>();
                if (animator != null)
                {
                    bool isOpen = animator.GetBool("show");
                    animator.SetBool("show", !isOpen);
                }
            }
        }

        void Start()
        {
            ShowHideMenu();
        }
    }
}

