using UnityEngine;
using System.Collections;

public class Five : MonoBehaviour, Node {
	
	public Person bird;
	public Person accomplice;
	public Wobject money;
	public Wobject letter;

	private bool guiState = false;
	private bool buttonClicked = false;
	private string decision = "";


	// Use this for initialization
	void Start () {
		this.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void accomplice_speaks (Person accomplice, string phrase) {
		//accomplice.say(phrase);
	}

	void accomplice_gives_letter (Person accomplice, Person bird, Wobject letter) {
		accomplice.remove_from_inventory (letter);
		bird.add_to_inventory (letter);
	}

	void money_to_inventory (Person accomplice, Person bird, Wobject money) {
		accomplice.remove_from_inventory (money);
		bird.add_to_inventory (money);
	}

	string get_player_input() {
		guiState = true;
		while (buttonClicked == false) {
			
		}
		guiState = false;
		return decision;
	}
	
	void OnGUI () {
		if (guiState) {
			// Make a background box
			GUI.Box (new Rect (10, 10, 100, 90), "Options");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if (GUI.Button (new Rect (20, 40, 80, 20), "Yes")) {
				decision = "Yes";
				buttonClicked = true;
			}
			// Make the second button.
			if (GUI.Button (new Rect (20, 70, 80, 20), "No")) {
				decision = "No";
				buttonClicked = true;
			}
		}
	}
}
