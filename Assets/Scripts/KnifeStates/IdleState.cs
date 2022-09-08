using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    Rigidbody rb;
    KnifeTouch kt;
    public IdleState(Rigidbody knifeRB, KnifeTouch knifeTouch)
    {
        rb = knifeRB;
        kt = knifeTouch;
    }
    public override void EnterState(StateManager stateManager)
    {
    }

    public override void FixedUpdateState(StateManager stateManager)
    {
        if (rb.velocity.magnitude > 0)
            stateManager.SwitchState(stateManager.movingState);

        
    }

    public override void UpdateState(StateManager stateManager)
    {
    }
    public override void OnTriggerEnter(StateManager stateManager ,Collider other)
    {
    }
}
