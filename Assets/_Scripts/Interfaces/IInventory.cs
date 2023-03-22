using System;
using System.Collections.Generic;

public interface IInventory
{
    public void AddItem(IItem item);
    public void RemoveItem(IItem item);
    public List<IItem> GetAll();
    public List<ISaleable> GetAllSaleables();
}