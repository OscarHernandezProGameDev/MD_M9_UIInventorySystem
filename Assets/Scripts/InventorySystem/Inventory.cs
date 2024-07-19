using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<Item> itemLists = new List<Item>();

    public Inventory()
    {
        itemLists = new List<Item>();
        AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 1 });
    }

    public void AddItem(Item item)
    {
        itemLists.Add(item);
    }

    public List<Item> GetItemLists() => itemLists;
}
