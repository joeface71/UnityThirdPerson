public class PlayerAttackingState : PlayerBaseState
{
    private Attack attack;

    public PlayerAttackingState(PlayerStateMachine stateMachine, int attackIndex) : base(stateMachine)
    {
        attack = stateMachine.Attacks[attackIndex];
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(attack.AnimationName, 0.1f);
    }

    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
    }


}
