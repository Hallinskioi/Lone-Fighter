using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level01Pluto : MonoBehaviour
{
    public Canvas uiCanvas;
    public Canvas storyCanvas;
    public Canvas optionsCanvas;
    public Canvas optionsButtonCanvas;

    public bool isStart = true;
    public Text continueButton;

    public Text storyText;

    public string[] story;
    private int index;
    public float typingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        uiCanvas.enabled = false;
        storyCanvas.enabled = true;
        optionsCanvas.enabled = false;
        BeginStory();
    }

    //UI


    public void BeginStory()
    {
        if (isStart == true)
        {
            continueButton.text = "Start";
        }
        else
        {
            continueButton.text = "Continue";
        }
    }
    IEnumerator Typing()
    {
        foreach(char letter in story[index].ToCharArray())
        {
            storyText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextLine()
    {
        if(index < story.Length -1)
        {
            index++;
            storyText.text = "";
            StartCoroutine(Typing());
            isStart = false;
            BeginStory();
        } else
        {
            storyText.text = "";
            OnceStoryDone();
        }
    }

    public void OnceStoryDone()
    {
        uiCanvas.enabled = true;
        storyCanvas.enabled = false;
    }

    public void OptionsCanvasEnabled()
    {
        optionsCanvas.enabled = true;
        // Pauses time.
    }

    public void OptionsQuitToMainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void OptionsResume()
    {
        optionsCanvas.enabled = false;
        // Unpause time
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        //Shooting
    }
}
