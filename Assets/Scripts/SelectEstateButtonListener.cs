using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectEstateButtonListener : MonoBehaviour 
{
	public int SelectEstate;

	public void MyClick (GameObject obj) 
	{
		if (SelectEstate == 2 || SelectEstate == 1 || SelectEstate == 3)
		{
			Application.LoadLevel("Loading");
		}
	}

	void Update()
	{
		
	}
}
