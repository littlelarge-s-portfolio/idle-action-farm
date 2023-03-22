using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    #region Variables
    private PlayerTradingManager _playerTradingManager;
    private PlayerInventory _playerInventory;

    public PlayerInventory Inventory { get { return _playerInventory; } }
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _playerTradingManager = GetComponent<PlayerTradingManager>();
        _playerInventory = GetComponent<PlayerInventory>();
    }
    #endregion
}