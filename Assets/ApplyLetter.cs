using UnityEngine;
using System.Collections;

public class ApplyLetter : MonoBehaviour {
	
	public GUISkin guiSkin;
	public string mymessage;
	public GameObject ldisplay;

	//Called every time the results screen is shown
	void OnGUI ()
	{
		//The GUI skin that defines styles for all of the components
		mymessage = Letter.messagedisplay;
		GUI.skin = guiSkin;
		GUI.Label (new Rect (Screen.width/8, Screen.height/8, (Screen.width*3)/4,  (Screen.height*3)/4), mymessage);
		
	}
	
	void Update() {
		if ((mymessage != "") && (Time.time <= Letter.messagetime)) {
			ldisplay.SetActive(true);
		}
		else {
			ldisplay.SetActive(false);
		}
	}
	
}
