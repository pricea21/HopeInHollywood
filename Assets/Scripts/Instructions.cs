using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public GameObject instructionsUI;
    public GameObject[] GameUI;
    public GameObject pauseMenu;
    public GameObject volumeControls;
    public GameObject startButton;
    public GameObject settingsButton;
    public GameObject pauseButton;
    public static bool GameIsPaused = false;
    private bool instructionsOn;
    private bool volumeOn;
    //private bool isPaused;
    

    void Update()
    {
          if (instructionsOn == true)
        {
            instructionsUI.SetActive(true);

            volumeControls.SetActive(false);
            volumeOn = false;

            pauseMenu.SetActive(false);
            GameIsPaused = false;

            settingsButton.SetActive(false);
            pauseButton.SetActive(false);
        }

        if (volumeOn == true)
        {
            instructionsUI.SetActive(false);
            instructionsOn = false;

            volumeControls.SetActive(true);

            pauseMenu.SetActive(false);
            GameIsPaused = false;

            settingsButton.SetActive(false);
            pauseButton.SetActive(false);
        }

        if (GameIsPaused == true)
        {
            instructionsUI.SetActive(false);
            instructionsOn = false;

            volumeControls.SetActive(false);
            volumeOn = false;

            pauseMenu.SetActive(true);

            settingsButton.SetActive(false);
            pauseButton.SetActive(false);
        }
    }


    public void Exit()
    {
        Time.timeScale = 1f;
        instructionsUI.SetActive(false);
        instructionsOn = false;

        volumeControls.SetActive(false);
        volumeOn = false;

        pauseMenu.SetActive(false);
        GameIsPaused = false;

        startButton.SetActive(true);
        settingsButton.SetActive(true);
        pauseButton.SetActive(true);
    }

    public void VolumeControl()
    {
        instructionsUI.SetActive(false);
        instructionsOn = false;

        startButton.SetActive(false);

        pauseMenu.SetActive(false);
        GameIsPaused = false;

        settingsButton.SetActive(true);
        pauseButton.SetActive(true);

        volumeControls.SetActive(true);
        volumeOn = true;
        Time.timeScale = 0f;
    }

    public void BackToInstructions()
    {
        volumeControls.SetActive(false);
        volumeOn = false;

        instructionsUI.SetActive(true);
        instructionsOn = true;

        GameIsPaused = false;
    }

    public void SettingsButton()
    {
        instructionsUI.SetActive(true);
        instructionsOn = true;
        volumeOn = false;
        GameIsPaused = false;
        Time.timeScale = 0f;
    }

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        GameIsPaused = true;
        volumeOn = false;
        instructionsOn = false;
    }
}

