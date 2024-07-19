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
        AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 99 });
        AddItem(new Item { itemType = Item.ItemType.ManaPotion, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Sword, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 98 });
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
                    int totalAmount = inventoryItem.amount + item.amount;
                    if (totalAmount <= 99)
                    {
                        inventoryItem.amount = totalAmount;
                        itemAllReadyInInventory = true;
                    }
                    else
                    {
                        int remainingAmount = totalAmount - 99;

                        inventoryItem.amount = 99;
                        item.amount = remainingAmount;
                    }
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
