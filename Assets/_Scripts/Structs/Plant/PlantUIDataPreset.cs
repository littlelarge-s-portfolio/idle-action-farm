using System;
using UnityEngine;

[Serializable]
public struct PlantUIDataPreset
{
    [SerializeField] private Sprite _growingImage;
    [SerializeField] private Sprite _grownImage;
    [SerializeField] private Sprite _cuttingImage;

    public Sprite GrowingImage { get { return _growingImage; } }
    public Sprite GrownImage { get { return _grownImage; } }
    public Sprite CuttingImage { get { return _cuttingImage; } }
}