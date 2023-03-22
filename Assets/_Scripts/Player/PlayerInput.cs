using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    #region Variables
    private FloatingJoystick _joystick;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _joystick = FindObjectOfType<FloatingJoystick>();
    }
    #endregion

    #region Methods
    public Vector2 GetDirection()
    {
        return new Vector2(_joystick.Horizontal, _joystick.Vertical);
    }
    #endregion
}

