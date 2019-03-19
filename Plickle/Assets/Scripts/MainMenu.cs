using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // FInd out what scene we are on and go to the next in order
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        // print to console saying that the quit button is hit
        Debug.Log("Quit");
        // quit the application
        Application.Quit();
    }
  
}
