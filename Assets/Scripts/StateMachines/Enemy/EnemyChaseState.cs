using UnityEngine;

public class EnemyChaseState : EnemyBaseState
{
    public EnemyChaseState(EnemyStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        Debug.Log("Entering Chase State");
    }
    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
    }


}
