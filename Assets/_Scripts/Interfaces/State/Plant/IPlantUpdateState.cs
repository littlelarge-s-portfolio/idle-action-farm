public interface IPlantUpdateState : IPlantState
{
    public void OnUpdateState(IPlantStateful stateful);
}