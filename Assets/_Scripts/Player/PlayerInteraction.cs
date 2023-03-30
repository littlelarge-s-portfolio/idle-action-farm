using UnityEngine;
using UnityEngine.Events;

public class PlayerInteraction : MonoBehaviour, ICutter
{
    #region Variables
    private Player _player;
    private bool _cutting;

    public bool Cutting { get { return _cutting; } }
    public ICutterAnimation Animation { get { return _player.Animation; } }
    public UnityEvent OnFinishMow { get; } = new UnityEvent();
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void Start()
    {
        OnFinishMow.AddListener(UnfreezeMovement);
    }
    #endregion

    #region Methods
    public void Mow(IPlant plant)
    {
        _cutting = true;

        _player.StateManager.ChangeState(new PlayerCuttingState());

        FreezeMovement(plant);
    }

    private void FreezeMovement(IPlant plant)
    {
        _player.Movement.Freeze();
        _player.Movement.LookAt(plant.GetTransform().position);
    }

    private void UnfreezeMovement()
    {
        _player.Movement.Unfreeze();

        _player.StateManager.GetCurrentState().NextState(_player.StateManager);

        _cutting = false;

        _player.Animation.ResetSlashAnimationLoopCount();
    }
    #endregion
}