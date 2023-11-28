using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;
public class CorrectAnswerButton : MonoBehaviour
{
    public PlayerCam playerCamera;
    public void ChangeButtonColor(TextMeshProUGUI buttonText)
    {
        buttonText.color = Color.green;
    }
    
    public void closePanel(GameObject u)
    {
        playerCamera.isCameraActive = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        u.SetActive(false);
    }

}
