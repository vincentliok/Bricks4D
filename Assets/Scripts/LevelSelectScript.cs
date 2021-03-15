using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
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
