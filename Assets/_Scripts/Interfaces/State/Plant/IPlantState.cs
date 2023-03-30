public interface IPlantState
{
    public void OnEnterState(IPlantStateful stateful);
    public void NextState(IPlantStateful stateful);
}