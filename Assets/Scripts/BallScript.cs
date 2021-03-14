using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        paddle = GameObject.Find("Ball Position").transform;

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
}
