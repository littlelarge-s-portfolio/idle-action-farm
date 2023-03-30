using UnityEngine;

public class WheatGrownState : IPlantCollisionStayState
{
    #region Methods
    public void OnEnterState(IPlantStateful stateful)
    {
        Debug.Log("I'm grown!");

        stateful.GetPlant().UIManager.SetGrown();
    }

    public void NextState(IPlantStateful stateful)
    {
        stateful.ChangeState(new WheatCuttingState());
    }

    public void OnCollisionStay(IPlantStateful stateful, ICutter cutter)
    {
        if (!cutter.Cutting)
        {
            Debug.Log("I'm translate to cutting state!");

            cutter.Mow(stateful.GetPlant());
            stateful.GetPlant().Cutter = cutter;

            NextState(stateful);
        }
    }
    #endregion
}