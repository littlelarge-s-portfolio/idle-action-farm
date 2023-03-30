public interface IPlantCollisionStayState : IPlantState
{
    public void OnCollisionStay(IPlantStateful stateful, ICutter cutter);
}