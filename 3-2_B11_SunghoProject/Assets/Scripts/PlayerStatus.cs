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

	private void Start()
	{
		PlayerStatusSet();
	}

	public void PlayerStatusSet()
	{
		atkTxt.text = playerData.attack.ToString();
		defTxt.text = playerData.defensive.ToString();
		criticalTxt.text = playerData.critical.ToString();
		healthTxt.text = playerData.health.ToString();
	}

}
