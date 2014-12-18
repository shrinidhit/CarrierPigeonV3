using UnityEngine;
using System.Collections;

public class Four : MonoBehaviour, Node {
	public static GameObject display;
	public static GameObject bird_object;
	public Player bird = new Player ("Bob", 0, 0, bird_object, display);

	public static GameObject owner_object;
	public Person owner = new Person("Owner", 0, 0, owner_object, display);

	public static GameObject bank_person_1_object;
	public Person bank_person_1 = new Person ("Joe", 0, 0, bank_person_1_object, display);

	public static GameObject bank_person_2_object;
	public Person bank_person_2 = new Person ("Bob", 0, 0, bank_person_2_object, display);

	public static GameObject bank_person_3_object;
	public Person bank_person_3 = new Person ("Lucy", 0, 0, bank_person_3_object, display);

	public static GameObject accomplice_object;
	public Person accomplice = new Person ("Accomplice", 0, 0, accomplice_object, display);

	public static GameObject third_letter_object;
	public static GameObject third_letter_location;
	public static string third_letter_message;
	public Letter third_letter = new Letter("Third Letter", 0, 0, third_letter_message, third_letter_location, third_letter_object);
	private Vector3[] accomplice_locations = new Vector3[] {new Vector3(0.0f,0.0f,0.0f),new Vector3(0.1f,0.1f,0.1f)};
	private string[] owner_phrases = new string[] {"Here, take this letter to my friend at the bank.","Take this letter.","Here's a letter."};
	private string[] bank_person_phrases = new string[] {"Hi there!","Oh look, a bird.","Ew, go away."};

	void Start () {
		Four.display = GameObject.FindWithTag("Player");
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		owner_speaks(owner, owner_phrases[Random.Range(0,owner_phrases.Length)]);
		letter_to_inventory (owner, bird, third_letter);
		bank_person_speaks (bank_person_1, bank_person_phrases [Random.Range (0, bank_person_phrases.Length)]);
		bank_person_speaks (bank_person_2, bank_person_phrases [Random.Range (0, bank_person_phrases.Length)]);
		bank_person_speaks (bank_person_3, bank_person_phrases [Random.Range (0, bank_person_phrases.Length)]);
		accomplice_runs (accomplice.get_object(), accomplice_locations [Random.Range (0, accomplice_locations.Length)]);
	}

	void owner_speaks (Person owner, string phrase) {
		owner.speak(phrase);
	}

	void letter_to_inventory (Person owner, Person bird, Mthing letter) {
		owner.remove_from_inventory (letter);
		bird.add_to_inventory (letter);
	}

	void bank_person_speaks (Person person, string phrase) {
		person.speak(phrase);
	}

	void accomplice_runs (GameObject accomplice, Vector3 location) {
		accomplice.transform.position = location;
	}
}
