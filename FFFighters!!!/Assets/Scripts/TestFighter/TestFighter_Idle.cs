using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFighter_Idle : FighterState<TestFighter>
{
    private static TestFighter_Idle instance;
    public static TestFighter_Idle Instance
    {
        get
        {
            if (instance == null)
                instance = new TestFighter_Idle();
            return instance;
        }
    }

    public TestFighter_Idle()
    {
        if (instance == null)
            instance = this;
    }

    // State methods
    public override void Enter(TestFighter owner, StateManager<TestFighter> stateManager)
    {
        Debug.Log("Entered State: TestFighter_Idle");
    }

    public override void Exit(TestFighter owner, StateManager<TestFighter> stateManager)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(TestFighter owner, StateManager<TestFighter> stateManager)
    {

    }

    // Player Input
    public override void Move(TestFighter owner, StateManager<TestFighter> stateManager, Vector2 direction)
    {

    }
}
