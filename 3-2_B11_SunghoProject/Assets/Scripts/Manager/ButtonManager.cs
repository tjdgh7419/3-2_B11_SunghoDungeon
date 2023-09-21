using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
	[SerializeField] private GameObject StatusInterface;
	[SerializeField] private GameObject ButtonInterface;

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
}
