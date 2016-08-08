using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Loading : MonoBehaviour {

	private float fps = 10.0f;
	private float time;

	public Texture2D[] animations;
	private int nowFram;

	AsyncOperation async;

	//between 0 - 1
	int progress = 0;

	string scenename = "View 1";

	public GameObject slider;
	public Text progtext;

	void Start()
	{
		slider.GetComponent<Slider>().value = 0;
		progtext.text = "0%";
		StartCoroutine(loadScene());
	}
		
	IEnumerator loadScene()
	{
		async = Application.LoadLevelAsync(scenename);

		yield return async;

	}

	void OnGUI()
	{
//		refresh UI
//		DrawAnimation(animations);
//		GUI.DrawTexture(Rect(0, 0, 100, 50), emptyProgressBar);
//		GUI.DrawTexture(Rect(0, 0, 100 * async.progress, 50), fullProgressBar);

	}

	void Update()
	{
		progress =  (int)(async.progress *100);

		slider.GetComponent<Slider>().value = async.progress;
		progtext.text = progress + "%";

	}

	void DrawAnimation(Texture2D[] tex)
	{

		time += Time.deltaTime;

		if(time >= 1.0 / fps){

			nowFram++;

			time = 0;

			if(nowFram >= tex.Length)
			{
				nowFram = 0;
			}
		}
		GUI.DrawTexture(new Rect( 100,100,40,60) ,tex[nowFram] );

		GUI.Label(new Rect( 100,180,300,60), "lOADING!!!!!" + progress);

	}
}
