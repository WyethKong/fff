using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager<T>
{
    T owner;
    State<T> currentState;

    public StateManager(T owner)
    {
        this.owner = owner; 
    }

    public State<T> GetState()
    {
        // Return the given state
        return currentState;
    }
    public void SetState(State<T> newState)
    {
        // Exit current state
        if (currentState != null)
            currentState.Exit(owner, this);

        // Set and Enter new state
        currentState = newState;
        currentState.Enter(owner, this);
    }

    public void UpdateState()
    {
        currentState.Update(owner, this);
    }
}

public abstract class State<T>
{
    // Base methods for all states
    public abstract void Enter(T owner, StateManager<T> stateManager);  // Occurs when changing to this state
    public abstract void Exit(T owner, StateManager<T> stateManager);   // Occurs when changing to another state
    public abstract void Update(T owner, StateManager<T> stateManager); // Occurs every FixedUpdate
}

public abstract class FighterState<Fighter> : State<Fighter>
{
    public virtual void Move(Fighter owner, StateManager<Fighter> stateManager, Vector2 direction) { }
    //public virtual void Attack(Fighter owner, StateManager<Fighter> stateManager, bool pressed) 
}
