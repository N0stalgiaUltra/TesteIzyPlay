using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicingState : BaseState
{
    Rigidbody rb;

    public SlicingState(Rigidbody rb)
    {
        this.rb = rb;
    }

    public override void EnterState(StateManager stateManager)
    {
        stateManager.ObjectSliceRef.SliceObject();
    }

    public override void FixedUpdateState(StateManager stateManager)
    {
        if (rb.velocity.magnitude > 0)
            stateManager.SwitchState(stateManager.movingState);
    }

    public override void OnTriggerEnter(StateManager stateManager, Collider other)
    {
    }

    public override void UpdateState(StateManager stateManager)
    {
    }
}
