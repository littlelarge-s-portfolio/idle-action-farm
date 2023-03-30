using UnityEngine;

public class PlayerRunningState : IPlayerUpdateState
{
    #region Methods
    public void OnEnterState(IPlayerStateful stateful)
    {
        stateful.GetPlayer().Animation.Running();
    }

    public void NextState(IPlayerStateful stateful)
    {
        stateful.ChangeState(new PlayerIdleState());
    }

    public void OnUpdateState(IPlayerStateful stateful)
    {
        if (stateful.GetPlayer().Input.Magnitude == 0)
            NextState(stateful);
    }
    #endregion
}