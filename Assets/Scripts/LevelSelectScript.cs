using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Credit for the background image goes to https://wallpapersafari.com/deep-space-wallpaper-1920x1080/

public class LevelSelectScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // detect click on sprite object

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                AudioManagerScript.Instance.playbeep();

                if (hit.collider.name == "Level1Button")
                {
                    SceneManager.LoadScene("Level1");
                }
                else if (hit.collider.name == "Level2Button")
                {
                    SceneManager.LoadScene("Level2");
                }
                else if (hit.collider.name == "Level3Button")
                {
                    SceneManager.LoadScene("Level3");
                }
            }
        }
    }
}
