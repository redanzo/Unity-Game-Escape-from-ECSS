using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class Question1 : MonoBehaviour
{
    public PlayerCam playerCamera;
    //public playerCheckpoints playerCheckpoints;
    public GameObject UI;
    private bool isActive = false;
    public void Start()
    {
        UI.SetActive(isActive);
    }
    public void Interact()
    {
        UnityEngine.Debug.Log("Puzzle interacted with");
        playerCamera.isCameraActive = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        isActive = true;
        UI.SetActive(isActive);
    }

    private void Update()
    {
       
    }
}
