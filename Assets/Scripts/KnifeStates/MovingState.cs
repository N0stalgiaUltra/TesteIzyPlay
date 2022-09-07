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
        //rb.isKinematic = false;
    }

    public override void FixedUpdateState(StateManager stateManager)
    {
       

    }

    public override void OnTriggerEnter(StateManager stateManager, Collider other)
    {

        Debug.Log(other.tag);
        if (other.CompareTag("Plataforma"))
            rb.isKinematic = true;

    }

    public override void UpdateState(StateManager stateManager)
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.isKinematic = false;
            kt.Impulse(rb);
        }
    }
}
