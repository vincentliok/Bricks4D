using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
