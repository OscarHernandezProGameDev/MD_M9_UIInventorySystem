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
}
