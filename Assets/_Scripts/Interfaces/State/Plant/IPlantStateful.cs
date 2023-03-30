public interface IPlantStateful
{
    public void ChangeState(IPlantState state);
    public IPlantState GetCurrentState();
    public IPlant GetPlant();
}