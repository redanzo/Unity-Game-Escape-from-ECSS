using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactRange = 2.0f;
    private GameObject rayCastedObject;
    private DoorController doorController;
    private const string interactableTag = "InteractiveObject";

    void Update()
    {
       
        // cast ray and check what it touches
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out hit, interactRange))
        {
            if(hit.collider.CompareTag(interactableTag))
            {
                
                if(Input.GetKeyDown(KeyCode.E)){
                    UnityEngine.Debug.Log("Interactable");  
                    rayCastedObject = hit.collider.gameObject;

                    // found door object
                    if(rayCastedObject.name == "a door")
                    {
                        doorInteraction();
                    }
                }
            }
        }   
    }

    private void doorInteraction(){
        doorController = rayCastedObject.GetComponentInParent<DoorController>();

        bool playerCanOpenDoor = doorController.doorUnlocked;
        UnityEngine.Debug.Log("play door anim");  
        if(playerCanOpenDoor){
            // play door animation
            

            doorController.PlayAnimation();
        }
        else{
            // play locked door sound
        }
    }
}
