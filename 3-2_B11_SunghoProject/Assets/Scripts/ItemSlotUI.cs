using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
	public Button button;
	public Image icon;
	public GameObject iconVal;
	public GameObject equipVal;
	public ItemData itemData;
	public int index;
	



	public void EquipClick()
	{
		Inventory.instance.EquipBtn(index);
	}
	
}
