using System;
using UnityEngine;

[Serializable]
public struct PlantModelDataPreset
{
    [SerializeField] private Transform _plant;

    public Transform Plant { get { return _plant; } }
}