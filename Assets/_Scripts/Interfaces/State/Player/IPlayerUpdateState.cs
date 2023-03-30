public interface IPlayerUpdateState : IPlayerState
{
    public void OnUpdateState(IPlayerStateful stateful);
}