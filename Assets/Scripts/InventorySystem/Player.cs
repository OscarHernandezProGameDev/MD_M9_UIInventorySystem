using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;
    [SerializeField] private GameObject inventoryMenu;
    [SerializeField] private EventsManager eventsManager;
    [SerializeField] private VerticalLayoutGroup barsLayout;

    private Inventory inventory;

    private Slider healthBar, manaBar;
    private int health = 50, mana = 50;
    private RectOffset rectOffset;

    public bool AtInventory { get; private set; }

    public void UseItem(Item item)
    {
        switch (item.itemType)
        {
            case Item.ItemType.HealthPotion:
                int newHealth = health + 10;

                StartCoroutine(UpdateHealthBar(newHealth));
                break;
            case Item.ItemType.ManaPotion:
                int newMana = mana + 10;

                StartCoroutine(UpdateManaBar(newMana));
                break;
        }

        inventory.UseItem(item);
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public Inventory GetInventory()
    {
        return inventory;
    }

    public void CloseInventory()
    {
        rectOffset = new RectOffset { left = 20, right = 20, top = 10, bottom = 980 };
        barsLayout.padding = rectOffset;
        barsLayout.childAlignment = TextAnchor.UpperLeft;

        inventoryMenu.SetActive(false);
        eventsManager.CleanSelection();
        AtInventory = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        CloseInventory();

        healthBar = GameObject.Find("Bar_Health").GetComponent<Slider>();
        manaBar = GameObject.Find("Bar_Mana").GetComponent<Slider>();

        healthBar.value = health;
        manaBar.value = mana;

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
        rectOffset = new RectOffset { left = 20, right = 20, top = 960, bottom = 40 };
        barsLayout.padding = rectOffset;
        barsLayout.childAlignment = TextAnchor.LowerLeft;

        inventoryMenu.SetActive(true);
        AtInventory = true;
    }

    private IEnumerator UpdateHealthBar(int newHealth)
    {
        float elapsedTime = 0;
        float duration = 0.5f;
        int initialHealth = health;

        health = Mathf.Clamp(newHealth, 0, 100);

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            healthBar.value = Mathf.Lerp(initialHealth, health, elapsedTime / duration);

            yield return null;
        }

        healthBar.value = newHealth;
    }

    private IEnumerator UpdateManaBar(int newMana)
    {
        float elapsedTime = 0;
        float duration = 0.5f;
        int initialMana = mana;

        mana = Mathf.Clamp(newMana, 0, 100);

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            manaBar.value = Mathf.Lerp(initialMana, mana, elapsedTime / duration);

            yield return null;
        }

        manaBar.value = newMana;
    }
}
