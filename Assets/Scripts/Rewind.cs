using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rewind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RewindTime()
    {
        SceneManager.LoadScene("StroyScene");
        Invoke("Reload", 4);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
