using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStateAim : BallStateBase
{
    public override void EnterState(BallScript ball)
    {

    }
    public override void Update(BallScript ball)
    {
        // move ball with paddle

        ball.transform.position = ball.paddle.position;

        // shoot ball

        if (Input.GetKey(KeyCode.Space))
        {
            ball.ChangeState(ball.stateMove);
        }
    }
    public override void LeaveState(BallScript ball)
    {

    }
}
