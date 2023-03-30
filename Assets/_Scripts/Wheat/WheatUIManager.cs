using UnityEngine;
using UnityEngine.UI;

public class WheatUIManager : MonoBehaviour, IPlantUIManager
{
    #region Variables
    [SerializeField] private PlantUIDataPreset _data;

    private Image _mainImage;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _mainImage = GetComponentInChildren<Image>();
    }
    #endregion

    #region Methods
    public void SetGrowing()
    {
        _mainImage.sprite = _data.GrowingImage;
    }

    public void SetGrown()
    {
        _mainImage.sprite = _data.GrownImage;
    }

    public void SetCutting()
    {
        _mainImage.sprite = _data.CuttingImage;
    }
    #endregion
}
