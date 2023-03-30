using UnityEngine;
using DG.Tweening;

public class WheatGrowingState : IPlantUpdateState
{
    #region Variables
    private float _time;
    private float _growTime = 10f;
    private Vector3 _grownSize;
    #endregion

    #region Methods
    public void OnEnterState(IPlantStateful stateful)
    {
        Debug.Log("I'm start growing!");

        IPlant plant = stateful.GetPlant();
        plant.UIManager.SetGrowing();

        _time = 0;

        Transform plantModel = plant.Data.ModelData.Plant;

        _grownSize = plantModel.localScale;

        plantModel.localScale = new Vector3(plantModel.localScale.x, 0, plantModel.localScale.z);

        Grow(stateful, plantModel);
    }

    public void NextState(IPlantStateful stateful)
    {
        stateful.ChangeState(new WheatGrownState());
    }

    public void OnUpdateState(IPlantStateful stateful)
    {
        _time += Time.deltaTime;
    }

    private void Grow(IPlantStateful stateful, Transform plantModel)
    {
        plantModel.DOScale(_grownSize, _growTime).OnComplete(() => NextState(stateful));
    }
    #endregion
}