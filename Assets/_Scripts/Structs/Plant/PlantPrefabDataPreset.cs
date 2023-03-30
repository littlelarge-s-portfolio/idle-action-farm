using System;
using UnityEngine;

[Serializable]
public struct PlantPrefabDataPreset
{
    [SerializeField] private GameObject _plantBlock;

    public GameObject PlantBlock { get { return _plantBlock; } }
}