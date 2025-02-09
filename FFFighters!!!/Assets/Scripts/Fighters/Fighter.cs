using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Fighter<T> : MonoBehaviour
{
    protected StateManager<T> stateManager;

    public virtual void Awake()
    {
        
    }

    public void DetectInput(InputAction.CallbackContext context)
    {
        Debug.Log(context.action.name);
        switch (context.action.name)
        {
            case ("Move"):

                return;
            default:
                Debug.LogWarning("Action '" + context.action.name + "' is unknown!");
                return;
        }
    }
}
