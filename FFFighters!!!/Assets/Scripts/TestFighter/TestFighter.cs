using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFighter : Fighter<TestFighter>
{
    public override void Awake()
    {
        base.Awake();
        stateManager = new StateManager<TestFighter>(this);
    }

    public void Start()
    {
        // Initialize the fighter in the idle state
        stateManager.SetState(TestFighter_Idle.Instance);
    }

    public void FixedUpdate()
    {
        // Update the current state
        stateManager.UpdateState();
    }
}
