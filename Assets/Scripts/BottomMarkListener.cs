using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BottomMarkListener : MonoBehaviour {

	public void MyClick (GameObject obj) 
	{
		Application.LoadLevel("SelectEstate");
	}

	void Update()
	{
		
	}
}
