using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State currentState;

    private void Update()
    {
        currentState?.Tick(Time.deltaTime); // nullable operators wont work with monobehaviours or scriptable objects
    }

    public void SwitchState(State newState)
    {
        currentState?.Exit(); // needed in case there was no previous state
        currentState = newState;
        currentState?.Enter();
    }
}
