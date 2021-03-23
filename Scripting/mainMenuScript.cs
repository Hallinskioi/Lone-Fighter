using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas newGameCanvas;
    public Canvas loadGameCanvas;
    public Canvas achievementCanvas;
    public Canvas optionsCanvas;
    public AudioSource mainMenuMusic;

    public Toggle easyToggle;
    public Toggle normalToggle;
    public Toggle hardToggle;
    public string newGameText;

    public Text newGameInfo;

    public void Start()
    {
        mainMenuCanvas.enabled = true;
        newGameCanvas.enabled = false;
    }

    // Scene Changes

    public void NewGameStart()
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

    public void NewGameButton()
    {
        mainMenuCanvas.enabled = false;
        newGameCanvas.enabled = true;
        DifficultyInfo();
    }

    public void NewGameBackButton()
    {
        mainMenuCanvas.enabled = true;
        newGameCanvas.enabled = false;
    }

    public void DifficultyInfo()
    {
        if (easyToggle.isOn)
        {
            newGameText = "For players new to 2D Shoot 'em up. Enemies have 50% less health";
        }
        else if (normalToggle.isOn)
        {
            newGameText = "The optimal experience. No game modifiers.";
        }
        else if (hardToggle.isOn)
        {
            newGameText = "For people who like a challenge. Enemies have 50% more health. Hazards kill on impact.";
        }
        DisplayNewGameText();
    }

    public void DisplayNewGameText()
    {
        newGameInfo.text = newGameText;
    }


    // Load Game Options/Panels
    public void LoadGameButton()
    {
        mainMenuCanvas.enabled = false;
        loadGameCanvas.enabled = true;
    }

    public void LoadGameBackButton()
    {
        mainMenuCanvas.enabled = true;
        loadGameCanvas.enabled = false;
    }

    // Achievement Panel

    public void AchieveButton()
    {
        mainMenuCanvas.enabled = false;
        achievementCanvas.enabled = true;
    }

    public void AchieveBackButton()
    {
        mainMenuCanvas.enabled = true;
        achievementCanvas.enabled = false;
    }

    //Options Panel

    public void OptionsButton()
    {
        mainMenuCanvas.enabled = false;
        optionsCanvas.enabled = true;
    }

    public void OptionsBackButton()
    {
        mainMenuCanvas.enabled = true;
        optionsCanvas.enabled = false;
    }
}
