using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGNORECookingC : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;
    
    public void StartCooking()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("cooking is on");
            animator.SetBool("IsOpen", isOpen);
        }
    }
   
}
