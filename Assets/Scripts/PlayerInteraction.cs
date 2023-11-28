using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactRange = 2.0f;
    private GameObject rayCastedObject;
    private const string interactableTag = "InteractiveObject";
    private Question1 questionController;
    void Update()
    {
       
        // cast ray and check what it touches
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out hit, interactRange))
        {
            if(hit.collider.CompareTag(interactableTag))
            {
                UnityEngine.Debug.Log("Interactable");  
                
                if(Input.GetKeyDown(KeyCode.E)){
                    rayCastedObject = hit.collider.gameObject;

                    // found door object
                    if(rayCastedObject.name == "a door")
                    {
                        doorInteraction();
                    }
                    else if(rayCastedObject.name == "a door2"){
                        doorInteraction2();
                    }
                    else if(rayCastedObject.name == "Puzzle1" || rayCastedObject.name == "Puzzle2" || rayCastedObject.name == "Puzzle3")
                    {
                        /* TODO */
                        UnityEngine.Debug.Log("Puzzle found");  
                        questionController = rayCastedObject.GetComponent<Question1>();

                        questionController.Interact();
                    }
                }
            }
        }   
    }

    private void doorInteraction(){
        DoorController doorController = rayCastedObject.GetComponentInParent<DoorController>();

        bool playerCanOpenDoor = doorController.doorUnlocked;
        UnityEngine.Debug.Log("play door anim");  
        // play door animation
        doorController.PlayAnimation();
        
    }

    private void doorInteraction2(){
        ExtraDoorController extraDoorController = rayCastedObject.GetComponentInParent<ExtraDoorController>();

        bool playerCanOpenDoor = extraDoorController.doorUnlocked;
        UnityEngine.Debug.Log("play door2 anim");  
        extraDoorController.PlayAnimation2();

    }
}
