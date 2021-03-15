using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    // go to level select screen

    public void play()
    {
        AudioManagerScript.Instance.playbeep();
        SceneManager.LoadScene("LevelSelect");
    }

    // go to main menu screen

    public void menu()
    {
        AudioManagerScript.Instance.playbeep();
        SceneManager.LoadScene("Menu");
    }
}
