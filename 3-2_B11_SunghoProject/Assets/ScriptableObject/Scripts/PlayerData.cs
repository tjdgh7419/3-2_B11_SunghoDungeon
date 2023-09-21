using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player")]
[System.Serializable]
public class PlayerData : ScriptableObject
{
	[Header("PlayerData")]
	public string id;
	public int level;
	public int gold;
	public int attack;
	public int defensive;
	public int critical;
	public int health;
	public string job;
}
