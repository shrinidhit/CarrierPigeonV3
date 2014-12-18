using UnityEngine;
using System.Collections;

public class Six : MonoBehaviour, Node {
	
	private bool guiState = false;
	private string decision = "";
	
	void Start () {
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		get_player_input ();
	}
	
	void get_player_input() {
		guiState = true;
	}
	
	void OnGUI () {
		if (guiState) {
			GUI.Box (new Rect (10, 10, 100, 90), "Options");
			if (GUI.Button (new Rect (20, 40, 80, 20), "Yes")) {
				decision = "Yes";
				guiState = false;
			}
			if (GUI.Button (new Rect (20, 70, 80, 20), "No")) {
				decision = "No";
				guiState = false;
			}
		}
	}

}
