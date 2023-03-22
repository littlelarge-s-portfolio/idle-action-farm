using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class CashUI : MonoBehaviour
{
    #region Variables
    private Cash _cash;

    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private Image _image;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _cash = GetComponent<Cash>();

        Init();
    }
    #endregion

    #region Methods
    public void Init()
    {
        _cash.OnChanged.AddListener(UpdateUI);
    }

    private void UpdateUI()
    {
        _textMeshPro.text = _cash.Value.ToString();
    }
    #endregion
}

