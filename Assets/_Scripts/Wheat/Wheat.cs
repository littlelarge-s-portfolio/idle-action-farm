using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class Wheat : MonoBehaviour, IItem, ISaleable
{
    #region Variables
    public float Cost { get; } = 10f;
    #endregion

    #region UnityMethods
    #endregion

    #region Methods
    public void Up(IInventory inventory)
    {
        inventory.AddItem(this);

        Destroy();
    }

    public void Sell(IBuyer buyer, IInventory inventory)
    {
        buyer.Buy(this);
        inventory.RemoveItem(this);
    }

    private void Destroy()
    {
        DestroyAnimation();
    }

    private void DestroyAnimation()
    {
        transform.DOScale(transform.lossyScale * 1.4f, .15f).OnComplete(() => transform.DOScale(0f, 3f)).OnComplete(() => Destroy(gameObject));
    }
    #endregion
}

