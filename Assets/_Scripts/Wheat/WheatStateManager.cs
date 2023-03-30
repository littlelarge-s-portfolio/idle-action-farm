using UnityEngine;

public class WheatStateManager : MonoBehaviour, IPlantStateful
{
    #region Variables
    private Wheat _wheat;
    private IPlantState _state;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _wheat = GetComponent<Wheat>();
    }

    private void Start()
    {
        InitState();
    }

    private void Update()
    {
        if (_state is IPlantUpdateState)
            ((IPlantUpdateState)_state).OnUpdateState((IPlantStateful)this);
    }
    #endregion

    #region Methods
    public void ChangeState(IPlantState state)
    {
	    _state = state;
        state.OnEnterState((IPlantStateful)this);
    }

    public IPlantState GetCurrentState()
    {
        return _state;
    }

    public IPlant GetPlant()
    {
        return _wheat;
    }

    private void InitState()
    {
        _state = new WheatGrownState();
        _state.OnEnterState(this);
    }
    #endregion
}

