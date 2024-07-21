using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private static int nextId = 0;

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
            {
                itemLists.Add(item);
                item.id = GenerateUniqueId();
            }
        }
        else
        {
            itemLists.Add(item);
            item.id = GenerateUniqueId();
        }
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveItem(Item item)
    {
        if (item.IsStackable())
        {
            Item itemInInventory = null;

            foreach (Item inventoryItem in itemLists)
            {
                if (inventoryItem.id == item.id)
                {
                    inventoryItem.amount -= item.amount;
                    itemInInventory = inventoryItem;
                }
            }

            if (itemInInventory != null && itemInInventory.amount <= 0)
                itemLists.Remove(itemInInventory);
        }
        else
            itemLists.Remove(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemLists() => itemLists;

    private int GenerateUniqueId()
    {
        return nextId++;
    }
}
