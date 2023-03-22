using UnityEngine;
using System.Collections;

public class Barn : MonoBehaviour, IBuyer
{
    #region Variables
    private Cash _cash;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _cash = FindObjectOfType<Cash>();
    }
    #endregion

    #region Methods
    public void Buy(ISaleable saleable)
    {
        _cash.Add(saleable.Cost);
    }
    #endregion
}

