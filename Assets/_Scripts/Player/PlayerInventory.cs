using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerInventory : MonoBehaviour, IInventory
{
    #region Variables
    private List<IItem> _items = new List<IItem>();
    #endregion

    #region Methods
    public void AddItem(IItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        _items.Remove(item);
    }

    public List<IItem> GetAll()
    {
        return _items;
    }

    public List<ISaleable> GetAllSaleables()
    {
        return _items.OfType<ISaleable>().ToList();
    }
    #endregion
}

