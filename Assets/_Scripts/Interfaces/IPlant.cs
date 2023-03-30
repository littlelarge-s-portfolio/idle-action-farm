using UnityEngine;

public interface IPlant
{
    public IPlantUIManager UIManager { get; }
    public IPlantData Data { get; }
    public ICutter Cutter { get; set; }

    public void SpawnPlantBlock();
    public Transform GetTransform();
}