using UnityEngine.Events;

public interface ICutter
{
    public bool Cutting { get; }
    public ICutterAnimation Animation { get; }
    public UnityEvent OnFinishMow { get; }

    public void Mow(IPlant plant);
}