public class PlayerStateMachine : StateMachine
{
    private void Start()
    {
        SwitchState(new PlayerTestState(this));
    }
}
