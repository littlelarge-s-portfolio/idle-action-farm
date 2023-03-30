using UnityEngine;
using UnityEngine.Events;

public class Cash : MonoBehaviour
{
    #region Variables
    private float _value;

    public UnityEvent OnChanged { get; } = new UnityEvent();
    public float Value { get { return _value; } }
    #endregion

    #region Methods
    public void Add(float value)
    {
        _value += value;

        Mathf.Clamp(_value, 0, Mathf.Infinity);

        OnChanged.Invoke();
    }

    public void Remove(float value)
    {
        _value -= value;

        Mathf.Clamp(_value - value, 0, Mathf.Infinity);

        OnChanged.Invoke();
    }
    #endregion
}