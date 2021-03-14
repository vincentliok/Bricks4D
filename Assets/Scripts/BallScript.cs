﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 200.0f;

    public float speed
    {
        get
        {
            return _speed;
        }

        private set
        {
            _speed = value;
        }
    }

    [SerializeField]
    private float _bounds = 7.0f;

    public float bounds
    {
        get
        {
            return _bounds;
        }

        private set
        {
            _bounds = value;
        }
    }

    public Rigidbody2D rb
    {
        get;
        private set;
    }

    public Transform paddle
    {
        get;
        private set;
    }

    private GameObject bricks;
    private Tilemap bricksTilemap;

    // states

    private BallStateBase currentState;
    public BallStateAim stateAim
    {
        get;
        private set;
    }
    public BallStateMove stateMove
    {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        paddle = GameObject.Find("Ball Position").transform;

        bricks = GameObject.Find("Bricks");
        bricksTilemap = bricks.GetComponent<Tilemap>();

        stateAim = new BallStateAim();
        stateMove = new BallStateMove();

        ChangeState(stateAim);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update(this);
    }

    public void ChangeState(BallStateBase newState)
    {
        if (currentState != null)
        {
            currentState.LeaveState(this);
        }

        currentState = newState;

        if (currentState != null)
        {
            currentState.EnterState(this);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // collision with bricks
        // I did not come up with this. Here is the link where I got the code:
        // https://github.com/Unity-Technologies/2d-techdemos/blob/master/Assets/Tilemap/Brick/Scripts/Ball.cs

        Vector3 hitPosition = Vector3.zero;
        if (bricksTilemap != null && bricks == collision.gameObject)
        {
            foreach (ContactPoint2D hit in collision.contacts)
            {
                hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
                hitPosition.y = hit.point.y - 0.01f * hit.normal.y;
                bricksTilemap.SetTile(bricksTilemap.WorldToCell(hitPosition), null);
            }
        }
    }
}
