using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI atkTxt;
	[SerializeField] private TextMeshProUGUI defTxt;
	[SerializeField] private TextMeshProUGUI criticalTxt;
	[SerializeField] private TextMeshProUGUI healthTxt;

	[SerializeField] private PlayerData playerData;
	int atk = 0, def = 0, cri = 0;
	private void Start()
	{
		ClearStats();
		PlayerStatusSet();
	}

	private void Update()
	{
		RenewStats();
		PlayerStatusSet();
	}

	public void PlayerStatusSet()
	{
		atkTxt.text = atk.ToString();
		defTxt.text = def.ToString();
		criticalTxt.text = cri.ToString();
		healthTxt.text = playerData.health.ToString();
	}

	public void RenewStats()
	{
		ClearStats();
		for (int i = 0; i < Inventory.instance.uiSlot.Length; i++)
		{
			if (Inventory.instance.uiSlot[i] != null && Inventory.instance.uiSlot[i].equipVal.activeSelf)
			{
				atk += Inventory.instance.uiSlot[i].itemData.attack;
				def += Inventory.instance.uiSlot[i].itemData.defensive;
				cri += Inventory.instance.uiSlot[i].itemData.critical;
			}
		}
	}
	public void ClearStats()
	{
		atk = playerData.attack;
		def = playerData.defensive;
		cri = playerData.critical;
	}

}
