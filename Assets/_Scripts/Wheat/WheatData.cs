using UnityEngine;

public class WheatData : MonoBehaviour, IPlantData
{
    #region Variables
    [SerializeField] PlantModelDataPreset _modelData;
    [SerializeField] PlantPrefabDataPreset _prefabData;

    public PlantModelDataPreset ModelData { get { return _modelData; } }
    public PlantPrefabDataPreset PrefabData { get { return _prefabData; } }
    #endregion
}