using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] public KnifeTouch knifeTouch;
    [SerializeField] private Rigidbody rb;

    [Header("Knife States")]
    private BaseState currentState;
    public IdleState idleState;
    public MovingState movingState;
    public SlicingState slicingState;
    

    private void Awake()
    {
        idleState = new IdleState(rb, knifeTouch);
        movingState = new MovingState(rb, knifeTouch);
        slicingState = new SlicingState(rb);
    }
    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    private void FixedUpdate()
    {
        currentState.FixedUpdateState(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(this, other);
    }

}
