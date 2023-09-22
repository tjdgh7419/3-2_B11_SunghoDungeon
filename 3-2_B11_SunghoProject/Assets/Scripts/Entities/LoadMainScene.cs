using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainScene : MonoBehaviour
{
    private const string Name = "PLAYER_NAME";
	private string name = null;
	public InputField inputTxt;

	private void Update()
	{
		name = inputTxt.GetComponent<InputField>().text;
		PlayerPrefs.SetString(Name, name);
	}
	public void LoadMain()
    {
		if (name != "")
		{
			SceneManager.LoadScene("MainScene");
		}
    }
}
