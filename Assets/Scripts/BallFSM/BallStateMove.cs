using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStateMove : BallStateBase
{
    public override void EnterState(BallScript ball)
    {
        ball.rb.AddForce(Vector2.up * ball.speed);
    }
    public override void Update(BallScript ball)
    {
        if (ball.transform.position.x > ball.bounds ||
            ball.transform.position.y > ball.bounds ||
            ball.transform.position.x < -ball.bounds ||
            ball.transform.position.y < -ball.bounds)
        {
            ball.ChangeState(ball.stateAim);
        }
    }
    public override void LeaveState(BallScript ball)
    {
        ball.rb.velocity = Vector2.zero;
    }
}
