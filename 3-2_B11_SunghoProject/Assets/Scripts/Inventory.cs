using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot
{
	public ItemData item;
	public int quantity;
}
public class Inventory : MonoBehaviour
{
	public ItemSlotUI[] uiSlot;
	public ItemSlot[] slots;
	public static Inventory instance;
	public GameObject equipUI;
	public GameObject unEquipUI;

	int idx = 0;
	private void Awake()
	{
		instance = this;
	}

	private void Start()
	{
		slots = new ItemSlot[uiSlot.Length];

		for (int i = 0; i < slots.Length; i++)
		{
			slots[i] = new ItemSlot();
			uiSlot[i].index = i;
		}

		for(int j = 0; j < uiSlot.Length; j++)
		{
			uiSlot[j].icon.sprite = uiSlot[j].itemData.itemImage;
		}
	}

	public void SelectItem(int index)
	{
		if (uiSlot[index].equipVal.activeSelf)
		{
			uiSlot[index].equipVal.SetActive(false);
			return;
		}
		uiSlot[index].equipVal.SetActive(true);
	}

	public void EquipBtn(int index)
	{
		if (uiSlot[index].equipVal.activeSelf)
		{
			unEquipUI.SetActive(true);
		}
		idx = index;
		equipUI.SetActive(true);
	}

	public void OnEquipBtn()
	{
		SelectItem(idx);
		equipUI.SetActive(false);
		unEquipUI.SetActive(false);
	}
	public void UnEquipBtn()
	{
		equipUI.SetActive(false);
		unEquipUI.SetActive(false);
	}
}
