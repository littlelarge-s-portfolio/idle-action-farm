using UnityEngine;

public class WheatCuttingState : IPlantUpdateState
{
    #region Variables
    private int _cuttingCount = 2;
    #endregion

    #region Methods
    public void OnEnterState(IPlantStateful stateful)
    {
        stateful.GetPlant().UIManager.SetCutting();
    }

    public void NextState(IPlantStateful stateful)
    {
        stateful.GetPlant().SpawnPlantBlock();

        stateful.ChangeState(new WheatGrowingState());
    }

    public void OnUpdateState(IPlantStateful stateful)
    {
        ICutter cutter = stateful.GetPlant().Cutter;

        if (cutter.Animation.GetBool(ICutterAnimation.AnimationsPreset.Slash))
        {
            int currentLoopCount = cutter.Animation.GetSlashAnimationLoopCount();

            Debug.Log($"I'm in cutting stage! Progress: {currentLoopCount}/{_cuttingCount}");

            if (currentLoopCount == _cuttingCount)
            {
                cutter.OnFinishMow.Invoke();
                NextState(stateful);
            }
        }
    }
    #endregion
}