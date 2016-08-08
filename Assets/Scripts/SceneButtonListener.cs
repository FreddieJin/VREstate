using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneButtonListener : MonoBehaviour 
{
	public GameObject nextScene;

	public void MyClick (GameObject obj) 
	{
		obj.transform.localScale = new Vector3(1f, 1f, 1f);
		GameObject currentscene = this.gameObject.transform.parent.gameObject;
		currentscene.SetActive(false);
		nextScene.SetActive(true);
	}

	void Update()
	{
		
	}
}
