using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;
    public AudioSource doorOpeningSound;
    public AudioSource lockedDoorSound;
    public AudioSource doorClosingSound;
    private bool doorOpen = false;

    // door should be locked initially
    public bool doorUnlocked = false;

    private void Awake()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
    }

    public void unlockDoor(){
        doorUnlocked = true;
    }

    public void PlayAnimation(){
        UnityEngine.Debug.Log("lock sound");
        if(doorUnlocked){
            if(!doorOpen){
                UnityEngine.Debug.Log("Door opened");
                
                doorAnimator.Play("newDoorAnim", 0, 0.0f);
                doorOpeningSound.Play();
            }
            else{
                UnityEngine.Debug.Log("Door closed");

                doorAnimator.Play("newDoorAnim2", 0, 0.0f);
                doorClosingSound.Play();

            }   
            doorOpen = !doorOpen;
        }
        else{
            lockedDoorSound.Play();
        }
    }
}


