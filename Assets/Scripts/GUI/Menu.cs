//C#
using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Options");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Do This")) {
			//Insert action here
			this.enabled = false;
			//Application.LoadLevel(1);
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Do That")) {
			//Insert action here
			this.enabled = false;
			//Application.LoadLevel(2);
		}
	}
}
