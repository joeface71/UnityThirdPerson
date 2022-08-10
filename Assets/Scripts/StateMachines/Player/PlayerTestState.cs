using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    float timer = 5f;

    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("Enter");
    }

    public override void Exit()
    {
        Debug.Log("Exit");
    }

    public override void Tick(float deltaTime)
    {
        timer -= deltaTime;
        Debug.Log(timer);

        if (timer <= 0)
        {
            stateMachine.SwitchState(new PlayerTestState(stateMachine));
        }
    }
}
