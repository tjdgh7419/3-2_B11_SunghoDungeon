using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
	[SerializeField] private GameObject StatusInterface;
	[SerializeField] private GameObject ButtonInterface;
	[SerializeField] private GameObject InventoryInterface;

	public void OnStatus()
	{
		ButtonInterface.SetActive(false);
		StatusInterface.SetActive(true);	
	}

	public void OffStatus()
	{
		ButtonInterface.SetActive(true);
		StatusInterface.SetActive(false);
	}

	public void OnInventory()
	{
		ButtonInterface.SetActive(false);
		InventoryInterface.SetActive(true);
	}

	public void OffInventory()
	{
		ButtonInterface.SetActive(true);
		InventoryInterface.SetActive(false);
	}
}
