using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingState : BaseState
{
    Rigidbody rb;
    KnifeTouch kt;
    float nextTouch;
    public MovingState(Rigidbody knifeRB, KnifeTouch knifeTouch)
    {
        rb = knifeRB;
        kt = knifeTouch;
    }
    public override void EnterState(StateManager stateManager)
    {
        nextTouch = stateManager.touchRate;
    }

    public override void FixedUpdateState(StateManager stateManager)
    {
       

    }

    public override void OnTriggerEnter(StateManager stateManager, Collider other)
    {
        if (other.CompareTag("Plataforma"))
            rb.Sleep();
        
        if (other.CompareTag("Slice"))
        {
            stateManager.slicingState.slicedObject = other.GetComponent<CubeObject>();
            stateManager.SwitchState(stateManager.slicingState);
        }
    }

    public override void UpdateState(StateManager stateManager)
    {
        nextTouch -= Time.deltaTime;

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began && nextTouch <= 0)
            {
                kt.Impulse(rb);
                nextTouch = stateManager.touchRate;
            }
            else
                Debug.Log("Next touch not ready");
        }
    }
}
