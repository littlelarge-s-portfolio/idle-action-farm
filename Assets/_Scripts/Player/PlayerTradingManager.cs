using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerTradingManager : MonoBehaviour, ITradeable
{
    #region Variables
    private Player _player;
    #endregion

    #region Methods
    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    public void SellAll(IBuyer buyer)
    {
        List<ISaleable> saleables = _player.Inventory.GetAllSaleables();

        foreach (ISaleable saleable in saleables)
            saleable.Sell(buyer, _player.Inventory);
    }
    #endregion
}

