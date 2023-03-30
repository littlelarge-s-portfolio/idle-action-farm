using UnityEngine;

public class PlayerAnimation : MonoBehaviour, ICutterAnimation
{
    #region Variables
    private Animator _animator;
    private int _slashAnimationPlayCount;
    private string[] _boolAnimations = new string[] { "Run", "Slash", "Idle" };
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    #endregion

    #region Methods
    public void Running()
    {
        SetBool(ICutterAnimation.AnimationsPreset.Run);
    }

    public void Idle()
    {
        SetBool(ICutterAnimation.AnimationsPreset.Idle);
    }

    public void Cutting()
    {
        SetBool(ICutterAnimation.AnimationsPreset.Slash);
    }

    public void OnSlashAnimationEnd()
    {
        _slashAnimationPlayCount += 1;
    }

    public void ResetSlashAnimationLoopCount()
    {
        _slashAnimationPlayCount = 0;
    }

    public bool GetBool(ICutterAnimation.AnimationsPreset animation)
    {
        return _animator.GetBool(animation.ToString());
    }

    public int GetSlashAnimationLoopCount()
    {
        return _slashAnimationPlayCount;
    }

    private void SetBool(ICutterAnimation.AnimationsPreset animation)
    {
        string animationName = animation.ToString();

        for (int i = 0; i < _boolAnimations.Length; i++)
        {
            if (_boolAnimations[i] == animationName)
                _animator.SetBool(_boolAnimations[i], true);
            else
                _animator.SetBool(_boolAnimations[i], false);
        }
    }
    #endregion

    #region Enums
    public enum AnimationsPreset
    {
        Run,
        Slash,
        Idle
    }
    #endregion
}