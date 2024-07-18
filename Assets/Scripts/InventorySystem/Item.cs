using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        HealthPotion,
        ManaPotion,
        Sword,
        Coin,
        Stone,
        Ring
    }

    public ItemType itemType;
    public int amount;
}
