using UnityEngine;

public class PlayerStateManager : MonoBehaviour, IPlayerStateful
{
    #region Variables
    private Player _player;
    private IPlayerState _state;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void Start()
    {
        InitState();
    }

    private void Update()
    {
        if (_state is IPlayerUpdateState)
            ((IPlayerUpdateState)_state).OnUpdateState(this);
    }
    #endregion

    #region Methods
    public void ChangeState(IPlayerState state)
    {
        _state = state;
        state.OnEnterState(this);
    }

    public IPlayerState GetCurrentState()
    {
        return _state;
    }

    public Player GetPlayer()
    {
        return _player;
    }

    private void InitState()
    {
        _state = new PlayerIdleState();
        _state.OnEnterState(this);
    }
    #endregion
}

