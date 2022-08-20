using UnityEngine;

public class EnemyAttackingState : EnemyBaseState
{
    private readonly int AttackHash = Animator.StringToHash("Attack");

    private const float CrossFadeDuration = 0.1f;


    public EnemyAttackingState(EnemyStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(AttackHash, CrossFadeDuration);
    }
    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
    }


}
