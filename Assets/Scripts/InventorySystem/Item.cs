using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
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

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.HealthPotion: return ItemAssets.Instance.healthPotionSprite;
            case ItemType.ManaPotion: return ItemAssets.Instance.manaPotionSprite;
            case ItemType.Sword: return ItemAssets.Instance.swordSprite;
            case ItemType.Coin: return ItemAssets.Instance.coinSprite;
            case ItemType.Stone: return ItemAssets.Instance.stoneSprite;
            case ItemType.Ring: return ItemAssets.Instance.ringSprite;
        }
    }

    public bool IsStackable()
    {
        switch(itemType)
        {
            default:
            case ItemType.HealthPotion:
            case ItemType.ManaPotion:
            case ItemType.Coin:
            case ItemType.Stone:
                return true;
            case ItemType.Sword:
            case ItemType.Ring: 
                return false;
        }
    }
}
