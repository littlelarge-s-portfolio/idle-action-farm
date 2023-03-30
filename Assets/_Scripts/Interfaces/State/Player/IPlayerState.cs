public interface IPlayerState
{
    public void OnEnterState(IPlayerStateful stateful);
    public void NextState(IPlayerStateful stateful);
}