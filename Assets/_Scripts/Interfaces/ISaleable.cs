public interface ISaleable
{
    public float Cost { get; }

    public void Sell(IBuyer buyer, IInventory inventory);
}