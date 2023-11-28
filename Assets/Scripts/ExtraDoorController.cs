using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraDoorController : MonoBehaviour
{
    private Animator doorAnimator;
    public AudioSource doorOpeningSound;
    public AudioSource doorClosingSound;
    public AudioSource lockedDoorSound;
    private bool doorOpen = false;

    // door should be locked initially
    public bool doorUnlocked = false;
    private char doorNumber;

    private void Awake()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
        doorNumber = gameObject.name[11];
        // UnityEngine.Debug.Log($"Door{doorNumber}");
    }

    public void unlockDoor(){
        doorUnlocked = true;
    }

    public void PlayAnimation2(){
        if(doorUnlocked){
            if(!doorOpen){
                UnityEngine.Debug.Log($"Door {doorNumber} opened");
                
                doorAnimator.Play($"Door{doorNumber}Open", 0, 0.0f);
                doorOpeningSound.Play();
            }
            else{
                UnityEngine.Debug.Log($"Door {doorNumber} closed");

                doorAnimator.Play($"Door{doorNumber}Close", 0, 0.0f);
                doorClosingSound.Play();
            }   
            doorOpen = !doorOpen;
        }
        else{
            lockedDoorSound.Play();
        }
    }
}
