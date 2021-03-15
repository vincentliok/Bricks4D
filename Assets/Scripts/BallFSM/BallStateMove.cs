using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStateMove : BallStateBase
{
    public override void EnterState(BallScript ball)
    {
        // move ball

        ball.rb.AddForce(Vector2.up * ball.speed);
    }
    public override void Update(BallScript ball)
    {
        // if ball leaves screen

        if (ball.transform.position.x > ball.bounds ||
            ball.transform.position.y > ball.bounds ||
            ball.transform.position.x < -ball.bounds ||
            ball.transform.position.y < -ball.bounds)
        {
            // destroy the ball by setting it to inactive

            ball.gameObject.SetActive(false);

            // see if there is another active ball in the scene

            List<GameObject> bp = ball.gms.ballPool;
            bool foundActive = false;
            for (int i = 0; i < bp.Count; i++)
            {
                if (bp[i].activeSelf)
                {
                    foundActive = true;
                    break;
                }
            }

            // if active ball not found, set self to active again and change state

            if (!foundActive)
            {
                ball.gameObject.SetActive(true);
                ball.ChangeState(ball.stateAim);

                // decrease life

                ball.gms.UpdateLives(-1);
            }
        }
    }
    public override void LeaveState(BallScript ball)
    {
        // stop ball

        ball.rb.velocity = Vector2.zero;
    }
}
