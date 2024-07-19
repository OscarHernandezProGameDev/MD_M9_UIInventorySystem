using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    [SerializeField] private Transform itemsContainer;
    [SerializeField] private GameObject itemsTemplate;

    private Inventory inventory;

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach (Item item in inventory.GetItemLists())
        {
            var newUIItem = Instantiate(itemsTemplate, itemsContainer).GetComponent<RectTransform>();

            newUIItem.name = item.itemType.ToString();
        }
    }
}
