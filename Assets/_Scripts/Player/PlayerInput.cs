using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region Variables
    private FloatingJoystick _joystick;
    private bool _canUseDirection;

    public float Magnitude { get { return GetDirection().magnitude; } }
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _joystick = FindObjectOfType<FloatingJoystick>();
    }

    private void Start()
    {
        _canUseDirection = true;
    }
    #endregion

    #region Methods
    public Vector2 GetDirection()
    {
        if (_canUseDirection)
            return new Vector2(_joystick.Horizontal, _joystick.Vertical);

        return Vector2.zero;
    }

    public void FreezeInput()
    {
        _canUseDirection = false;
    }

    public void UnfreezeInput()
    {
        _canUseDirection = true;
    }
    #endregion
}

