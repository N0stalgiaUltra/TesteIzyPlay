using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicingState : BaseState
{
    Rigidbody rb;
    public CubeObject slicedObject;
    bool isSlicing;

    public SlicingState(Rigidbody rb)
    {
        this.rb = rb;
    }

    public override void EnterState(StateManager stateManager)
    {
        isSlicing = true;

    }

    public override void FixedUpdateState(StateManager stateManager)
    {
        if (rb.velocity.magnitude > 0 && !isSlicing)
            stateManager.SwitchState(stateManager.movingState);
    }

    public override void OnTriggerEnter(StateManager stateManager, Collider other)
    {
    }

    public override void UpdateState(StateManager stateManager)
    {
        if (isSlicing)
        {
            stateManager.knifeTouch.SliceObject(slicedObject);
            isSlicing = false;
        }
        else
            return;
    }
}
