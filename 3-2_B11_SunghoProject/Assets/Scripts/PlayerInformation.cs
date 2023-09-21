using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{
    [SerializeField]private PlayerData playerData;
    [SerializeField] private TextMeshProUGUI idTxt;
	[SerializeField] private TextMeshProUGUI levelTxt;
	[SerializeField] private TextMeshProUGUI JobTxt;
	[SerializeField] private TextMeshProUGUI GoldTxt;
	void Start()
    {
        PlayerInfoSet();
    }  

    public void PlayerInfoSet()
    {
        idTxt.text = playerData.id;
        levelTxt.text = playerData.level.ToString();
		JobTxt.text = playerData.job;
        GoldTxt.text = playerData.gold.ToString();
    }
}
