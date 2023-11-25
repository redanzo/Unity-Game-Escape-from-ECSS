using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;
    
    private bool doorOpen = false;

    // door should be locked initially
    public bool doorUnlocked = true;

    private void Awake()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation(){
        if(!doorOpen){
            UnityEngine.Debug.Log("Door opened");

            doorAnimator.Play("newDoorAnim", 0, 0.0f);
        }
        else{
            UnityEngine.Debug.Log("Door closed");

            doorAnimator.Play("newDoorAnim2", 0, 0.0f);
        }   
        doorOpen = !doorOpen;
    }
}


