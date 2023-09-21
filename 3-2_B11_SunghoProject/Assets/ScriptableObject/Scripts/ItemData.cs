using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public int attack;
    public int defensive;
    public int critical;
}
