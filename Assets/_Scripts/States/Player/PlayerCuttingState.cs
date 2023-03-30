using UnityEngine;

public class PlayerCuttingState : IPlayerState
{
    #region Methods
    public void OnEnterState(IPlayerStateful stateful)
    {
        stateful.GetPlayer().Animation.Cutting();
    }

    public void NextState(IPlayerStateful stateful)
    {
        if (stateful.GetPlayer().Input.Magnitude == 0)
            stateful.ChangeState(new PlayerIdleState());
        else if (stateful.GetPlayer().Input.Magnitude > 0)
            stateful.ChangeState(new PlayerRunningState());
    }
    #endregion
}