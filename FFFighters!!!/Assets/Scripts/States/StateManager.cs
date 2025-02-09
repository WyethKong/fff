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
        return currentState;
    }
    public void SetState(State<T> newState)
    {
        if (currentState != null)
            currentState.Exit(owner, this);
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
    public abstract void Enter(T owner, StateManager<T> stateManager);
    public abstract void Update(T owner, StateManager<T> stateManager);
    public abstract void Exit(T owner, StateManager<T> stateManager);
}

public abstract class FighterState<Fighter> : State<Fighter>
{
    public virtual void Move(Fighter owner, StateManager<Fighter> stateManager, Vector2 direction) { }
    //public virtual void Attack(Fighter owner, StateManager<Fighter> stateManager, bool pressed) 
}
