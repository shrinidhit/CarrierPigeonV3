using UnityEngine;
using System.Collections;

public class Two : MonoBehaviour, Node {
	public static GameObject display;
	public static GameObject bird_object;
	public Player bird = new Player ("Bob", 0, 0, bird_object);
	public static GameObject accomplice_object;
	public Person accomplice = new Person ("Accomplice", 0, 0, accomplice_object);
	public static GameObject second_letter_object;

	public static GameObject second_letter_location;
	public static string second_letter_message;
	public Letter second_letter = new Letter("Second Letter", 0, 0, second_letter_message, second_letter_location, second_letter_object);
	
	private bool guiState = false;
	private string decision = "";
	private string[] accomplice_phrases = new string[] {"Here, take this letter.","Take this letter.","Bring this letter to your owner."};

	void Start () {
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		accomplice_speaks (accomplice, accomplice_phrases [Random.Range (0, accomplice_phrases.Length)]);
		accomplice_takes_letter (accomplice, bird, second_letter);
		accomplice_gives_letter (accomplice, bird, second_letter);
		get_player_input ();
	}

	void accomplice_speaks (Person accomplice, string phrase) {
		accomplice.speak (phrase);
	}

	void accomplice_takes_letter (Person accomplice, Person bird, Mthing letter) {
		accomplice.add_to_inventory (letter);
		bird.remove_from_inventory (letter);
	}
	
	void accomplice_gives_letter (Person accomplice, Person bird, Mthing letter) {
		bird.add_to_inventory (letter);
		accomplice.remove_from_inventory (letter);
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
