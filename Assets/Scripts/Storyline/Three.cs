using UnityEngine;
using System.Collections;

public class Three : MonoBehaviour, Node {

	private bool guiState = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}




	void display_letter () {
		guiState = true;
	}

	void OnGui () {
		if (guiState) {
			//On click back button...
			guiState = false;
		}
	}

}
