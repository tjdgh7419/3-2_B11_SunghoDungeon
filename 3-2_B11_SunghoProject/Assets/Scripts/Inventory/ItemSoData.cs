using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSoData : MonoBehaviour
{
	public ItemData item;
	public Image icon;

	private void Start()
	{
		ImgInput();
	}

	public void ImgInput()
	{
		icon.sprite = item.itemImage;
	}

}
