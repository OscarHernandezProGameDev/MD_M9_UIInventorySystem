using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChanged;
    public List<Item> itemLists = new List<Item>();

    public Inventory()
    {
        itemLists = new List<Item>();
        AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.ManaPotion, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Sword, amount = 1 });
    }

    public void AddItem(Item item)
    {
        if (item.IsStackable())
        {
            bool itemAllReadyInInventory = false;

            foreach (Item inventoryItem in itemLists)
            {
                if (inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount += item.amount;
                    itemAllReadyInInventory = true;
                }
            }

            if (!itemAllReadyInInventory)
                itemLists.Add(item);
        }
        else
            itemLists.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemLists() => itemLists;
}
