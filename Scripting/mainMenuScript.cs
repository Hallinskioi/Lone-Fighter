using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public AudioSource mainMenuMusic;

    public void Start()
    {
        Debug.Log("Test");
    }

    // Scene Changes

    public void StartNewGame()
    {
        SceneManager.LoadScene("Pluto");
    }

    public void EndlessGameStart()
    {
        SceneManager.LoadScene("EndlessMode");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    //New Game Options/Panels

    public void NewGameOptions()
    {

    }

}
