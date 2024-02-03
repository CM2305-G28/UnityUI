using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMenuButton : MonoBehaviour
{
    public GameObject PanelMenu;

    public void TransMenu()
    {
        //Play show/hide animation
        if(PanelMenu != null)
        {
            Animator animator = PanelMenu.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }
}
