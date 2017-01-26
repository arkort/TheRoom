using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<InventoryItemScript> _items;

	public Inventory()
    {
        _items = new List<InventoryItemScript>();
    }

    public void AddToInventory(InventoryItemScript item)
    {
        _items.Add(item);
    }
}
