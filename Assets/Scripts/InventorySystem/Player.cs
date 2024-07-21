using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;
    [SerializeField] private GameObject inventoryMenu;
    [SerializeField] private EventsManager eventsManager;

    private Inventory inventory;

    public bool AtInventory { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        CloseInventory();

        //ItemWorld.SpawnItemWorld(new Vector3(-0.4f, -2.82f), new Item { itemType = Item.ItemType.HealthPotion, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(-0.9f, -2.82f), new Item { itemType = Item.ItemType.ManaPotion, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(3, -2.82f), new Item { itemType = Item.ItemType.Sword, amount = 1 });
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ItemWorld itemWorld = other.GetComponent<ItemWorld>();

        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard != null)
        {
            if (keyboard.tabKey.wasPressedThisFrame)
            {
                if (inventoryMenu.activeInHierarchy)
                    CloseInventory();
                else
                    OpenInventory();
            }
        }
    }

    private void OpenInventory()
    {
        inventoryMenu.SetActive(true);
        AtInventory = true;
    }

    private void CloseInventory()
    {
        inventoryMenu.SetActive(false);
        eventsManager.CleanSelection();
        AtInventory = false;
    }
}
