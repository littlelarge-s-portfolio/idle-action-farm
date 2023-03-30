using UnityEngine;

public class PlayerIdleState : IPlayerUpdateState
{
    #region Methods
    public void OnEnterState(IPlayerStateful stateful)
    {
        stateful.GetPlayer().Animation.Idle();
    }

    public void NextState(IPlayerStateful stateful)
    {
        stateful.ChangeState(new PlayerRunningState());
    }

    public void OnUpdateState(IPlayerStateful stateful)
    {
        if (stateful.GetPlayer().Input.Magnitude > 0)
            NextState(stateful);
    }
    #endregion
}

