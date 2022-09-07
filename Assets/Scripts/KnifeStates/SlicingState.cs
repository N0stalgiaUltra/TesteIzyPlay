using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicingState : BaseState
{
    Rigidbody rb;
    ObjectSlice objectSlice;

    public SlicingState(Rigidbody rb, ObjectSlice objectSlice)
    {
        this.rb = rb;
        this.objectSlice = objectSlice;
    }

    public override void EnterState(StateManager stateManager)
    {
        throw new System.NotImplementedException();
    }

    public override void FixedUpdateState(StateManager stateManager)
    {
        throw new System.NotImplementedException();
    }

    public override void OnTriggerEnter(StateManager stateManager, Collider other)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(StateManager stateManager)
    {
        throw new System.NotImplementedException();
    }
}
