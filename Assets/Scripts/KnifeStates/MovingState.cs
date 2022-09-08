using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingState : BaseState
{
    Rigidbody rb;
    KnifeTouch kt;
    public MovingState(Rigidbody knifeRB, KnifeTouch knifeTouch)
    {
        rb = knifeRB;
        kt = knifeTouch;
    }
    public override void EnterState(StateManager stateManager)
    {
    }

    public override void FixedUpdateState(StateManager stateManager)
    {
       

    }

    public override void OnTriggerEnter(StateManager stateManager, Collider other)
    {
        if (other.CompareTag("Plataforma"))
            rb.Sleep();
        
        if (other.CompareTag("Slice"))
            stateManager.SwitchState(stateManager.slicingState);
    }

    public override void UpdateState(StateManager stateManager)
    {
        if (Input.GetMouseButtonDown(0))
        {
            kt.Impulse(rb);
        }
    }
}
