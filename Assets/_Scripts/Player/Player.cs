using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables
    private PlayerTradingManager _playerTradingManager;
    private PlayerInventory _playerInventory;
    private PlayerInteraction _playerInteraction;
    private PlayerAnimation _playerAnimation;
    private PlayerStateManager _playerStateManager;
    private PlayerInput _playerInput;
    private PlayerMovement _playerMovement;

    public PlayerInventory Inventory { get { return _playerInventory; } }
    public PlayerAnimation Animation { get { return _playerAnimation; } }
    public PlayerStateManager StateManager { get { return _playerStateManager; } }
    public PlayerInput Input { get { return _playerInput; } }
    public PlayerMovement Movement { get { return _playerMovement; } }
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _playerTradingManager = GetComponent<PlayerTradingManager>();
        _playerInventory = GetComponent<PlayerInventory>();
        _playerAnimation = GetComponent<PlayerAnimation>();
        _playerStateManager = GetComponent<PlayerStateManager>();
        _playerInput = GetComponent<PlayerInput>();
        _playerMovement = GetComponent<PlayerMovement>();
    }
    #endregion
}