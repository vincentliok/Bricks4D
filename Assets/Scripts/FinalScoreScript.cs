using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Show the final score

        GetComponent<Text>().text = "Final Score: " + Data.score;
    }
}
