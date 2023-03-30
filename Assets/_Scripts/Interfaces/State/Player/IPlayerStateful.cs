public interface IPlayerStateful
{
    public void ChangeState(IPlayerState state);
    public IPlayerState GetCurrentState();
    public Player GetPlayer();
}