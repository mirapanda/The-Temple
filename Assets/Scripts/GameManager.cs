﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject fadeOutUI;
    public GameObject instructionsUI;
    public GameObject crosshairs;
    public GameObject walkingDialogue;

    public void HowToPlay()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("HOW TO PLAY");
            instructionsUI.SetActive(false);
            walkingDialogue.SetActive(true);
        }
    }

    public void CompleteGame ()
    {
        Debug.Log("COMPLETE");
        fadeOutUI.SetActive(true);
        crosshairs.SetActive(false);
    }
}