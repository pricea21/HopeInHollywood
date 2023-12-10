using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing.MiniJSON;
using UnityEngine.SceneManagement;

public class LevelDifficulty : MonoBehaviour
{
    public GameObject difficultyPanel;
    public GameObject instructionsPanel;
    public GameObject settingsButton;
    public GameObject pauseButton;
    private bool isOn;

    void Update()
    {
        if (isOn == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void Regular()
    {
        difficultyPanel.SetActive(false);
        isOn = false;
        Time.timeScale = 1f;
        settingsButton.SetActive(true);
        pauseButton.SetActive(true);

    }

    public void RegularSP()
    {
        isOn = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("SlidingPuzzle");
    }

    public void HardSP()
    {
        isOn = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("SlidingPuzzleHard");
    }

    public void ChangeDifficulty()
    {
        instructionsPanel.SetActive(false);
        difficultyPanel.SetActive(true);
        isOn = true;
    }
}
