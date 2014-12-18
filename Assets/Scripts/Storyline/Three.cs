using UnityEngine;
using System.Collections;

public class Three : MonoBehaviour, Node {

	private bool guiState = false;
	
	void Start () {
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		display_letter ();
	}

	void display_letter () {
		guiState = true;
	}

	void OnGui () {
		if (guiState) {
			//Show letter

			//On click back button...
			guiState = false;
		}
	}

}
