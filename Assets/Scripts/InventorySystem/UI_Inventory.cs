using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    [SerializeField] private Transform itemsContainer;
    [SerializeField] private GameObject itemsTemplate;

    private Inventory inventory;

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;

        inventory.OnItemListChanged += Inventory_OnItemListChanged;

        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChanged(object sender, EventArgs e)
    {
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach (Transform child in itemsContainer)
        {
            if (child == itemsTemplate)
                continue;

            Destroy(child.gameObject);
        }

        foreach (Item item in inventory.GetItemLists())
        {
            var newUIItem = Instantiate(itemsTemplate, itemsContainer).GetComponent<RectTransform>();

            newUIItem.name = item.itemType.ToString();

            var image = newUIItem.Find("Border/Image").GetComponent<Image>();

            image.sprite = item.GetSprite();
        }
    }
}