using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPaddleScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float leftBound = -3.6f;

    [SerializeField]
    private float rightBound = 3.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move left

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // move right

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        // stay within left bound

        if (transform.position.x < leftBound)
        {
            transform.position = new Vector2(leftBound, transform.position.y);
        }

        // stay within right bound

        if (transform.position.x > rightBound)
        {
            transform.position = new Vector2(rightBound, transform.position.y);
        }

    }
}
