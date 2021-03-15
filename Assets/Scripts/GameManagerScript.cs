using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    [System.NonSerialized]
    public List<GameObject> ballPool;

    [SerializeField]
    private GameObject ballpf;

    [SerializeField]
    private int poolSize;

    [SerializeField]
    private int lives = 3;

    private Text livesText;

    [SerializeField]
    private int brickPoints = 10;

    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // setup object pool of balls

        ballPool = new List<GameObject>();
        GameObject temp;
        for (int i = 0; i < poolSize; i++)
        {
            temp = Instantiate(ballpf);
            temp.SetActive(false);
            ballPool.Add(temp);
        }

        ballPool[0].SetActive(true);

        livesText = GameObject.Find("LivesText").GetComponent<Text>();
        livesText.text = "Lives: " + lives;

        Data.score = 0;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "Score: " + Data.score;
    }

    public void UpdateLives(int changeInLives)
    {
        if (lives <= 1)
        {
            SceneManager.LoadScene("End");
        }

        lives += changeInLives;
        livesText.text = "Lives: " + lives;
    }

    // change the score in Data

    public void UpdateScore()
    {
        Data.score += brickPoints;
        scoreText.text = "Score: " + Data.score;
    }
}
