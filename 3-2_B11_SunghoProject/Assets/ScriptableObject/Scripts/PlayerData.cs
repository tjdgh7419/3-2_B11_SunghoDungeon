using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player")]
[System.Serializable]
public class PlayerData : ScriptableObject
{
	[Header("Player")]
	public string id;
	public int level;
	public int gold;
}
