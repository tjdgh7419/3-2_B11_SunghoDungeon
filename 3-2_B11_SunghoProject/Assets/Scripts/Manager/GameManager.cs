using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private const string Name = "PLAYER_NAME";
	[SerializeField] private PlayerData playerData;
    void Start()
    {
        playerData.id = PlayerPrefs.GetString(Name);
	}
}
