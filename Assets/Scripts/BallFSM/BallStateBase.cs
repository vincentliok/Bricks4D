using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallStateBase
{
    public abstract void EnterState(BallScript ball);
    public abstract void Update(BallScript ball);
    public abstract void LeaveState(BallScript ball);
}
