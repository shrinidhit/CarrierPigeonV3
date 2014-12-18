using UnityEngine;
using System.Collections;

public class Five : MonoBehaviour, Node {
	public static GameObject display;

	public static GameObject bird_object;
	public Player bird = new Player ("Bob", 0, 0, bird_object, display);

	public static GameObject accomplice_object;
	public Person accomplice = new Person ("Accomplice", 0, 0, accomplice_object, display);

	public static GameObject fourth_letter_object;
	public static GameObject fourth_letter_location;
	public static string fourth_letter_message;
	public Letter fourth_letter = new Letter("Fourth Letter", 0, 0, fourth_letter_message, fourth_letter_location, fourth_letter_object);

	public static GameObject money_object;
	public Mthing money = new Mthing("Money", 0, 0, money_object);

	private bool guiState = false;
	private string decision = "";
	private string[] accomplice_phrases = new string[] {"Here, take this letter.","Take this letter.","Bring this letter to your owner."};
	
	void Start () {
		Five.display = GameObject.FindWithTag("Player");
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		accomplice_speaks (accomplice, accomplice_phrases [Random.Range (0, accomplice_phrases.Length)]);
		accomplice_gives_letter (accomplice, bird, fourth_letter);
		money_to_inventory (accomplice, bird, money);
		get_player_input ();
	}

	void accomplice_speaks (Person accomplice, string phrase) {
		accomplice.speak(phrase);
	}

	void accomplice_gives_letter (Person accomplice, Person bird, Mthing letter) {
		accomplice.remove_from_inventory (letter);
		bird.add_to_inventory (letter);
	}

	void money_to_inventory (Person accomplice, Person bird, Mthing money) {
		accomplice.remove_from_inventory (money);
		bird.add_to_inventory (money);
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
