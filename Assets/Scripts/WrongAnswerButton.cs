using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WrongAnswerButton : MonoBehaviour
{
    public GameObject panel;
    public playerCheckpoints playercps;

    void Update(){
    }

    public void ChangeButtonColor(TextMeshProUGUI buttonText)
    {
        buttonText.color = Color.red; // Change text color to red
    }

    public void IncrementIncorrectAnswers()
    {
        playercps.numIncorrectAnswers++;
        playercps.resetPlayer(panel);
    }

}
