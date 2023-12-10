using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerPM : MonoBehaviour
{
    public int keys = 0;
    public float speed = 5.0f;

    public Text keyAmount;
    public Text youWin;
    public GameObject door;
    public GameObject KeyText;
    public GameObject instructionsUI;
    public GameObject settingsButton;
    public GameObject pauseButton;
    public GameObject hardEnemies;
    public GameObject difficultyPanel;

    private bool isOn;
    void Start()
    {
        if (GameManager.firstTime)
        {
            isOn = true;
            instructionsUI.SetActive(true);
            difficultyPanel.SetActive(true);
            Time.timeScale = 0f;
            GameManager.firstTime = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (keys == 5)
        {
            Destroy(door);
        }

        if (isOn == true)
        {
            Time.timeScale = 0f;
            settingsButton.SetActive(false);
            pauseButton.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            settingsButton.SetActive(true);
            pauseButton.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Keys")
        {
            keys++;
            keyAmount.text = "Teams: " + keys;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Princess")
        {
            Destroy(collision.gameObject);
            youWin.text = "YOU WIN!!!";
            GameManager.instance.SetMinigameComplete("Puzzle Maze");
            Invoke("Next", 2);
        }
        if (collision.gameObject.tag == "Enemies")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            settingsButton.SetActive(true);
            KeyText.SetActive(true);
        }

    }

    public void Hard()
    {
        hardEnemies.SetActive(true);
        isOn = false;
        difficultyPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Regular()
    {
        isOn = false;
        difficultyPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Next()
    {
        SceneManager.LoadScene("Map");
    }
}
