using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public GameObject instructionsUI;
    public GameObject celebrityKey;
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GoBackToMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void CelebrityKey()
    {
        celebrityKey.SetActive(true);
        instructionsUI.SetActive(false);
    }

    public void Instructions()
    {
        celebrityKey.SetActive(false);
        instructionsUI.SetActive(true);
    }
}
