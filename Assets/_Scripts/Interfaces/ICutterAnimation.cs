public interface ICutterAnimation
{
    public void Cutting();
    public void OnSlashAnimationEnd();
    public void ResetSlashAnimationLoopCount();
    public bool GetBool(AnimationsPreset animation);
    public int GetSlashAnimationLoopCount();

    public enum AnimationsPreset
    {
        Run,
        Slash,
        Idle
    }
}