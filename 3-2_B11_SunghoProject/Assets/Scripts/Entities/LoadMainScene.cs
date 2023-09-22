using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainScene : MonoBehaviour
{
    private const string Name = "PLAYER_NAME";
	private string name = null;
	[SerializeField] private InputField inputTxt;
	public void LoadMain()
    {
		name = inputTxt.text;
		PlayerPrefs.SetString(Name, name);

		if (name != "")
		{
			SceneManager.LoadScene("MainScene");
		}
    }
}
