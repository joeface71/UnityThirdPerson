public abstract class PlayerBaseState : State // Since this is abstract we dont need to implement State here
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

}
