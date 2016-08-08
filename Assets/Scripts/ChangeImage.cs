using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeImage : MonoBehaviour {

	public Sprite originSprite;
	public Sprite highlightedSprite;

	// Use this for initialization
	void Start () {
		if (originSprite == null)
		{
			originSprite = GetComponent<Image>().sprite;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
