using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VPaddleScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float bounds = 3.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move up

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        // move down

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        // stay within top bound

        if (transform.position.y > bounds)
        {
            transform.position = new Vector2(transform.position.x, bounds);
        }

        // stay within bottom bound

        if (transform.position.y < -bounds)
        {
            transform.position = new Vector2(transform.position.x, -bounds);
        }
    }
}
