using UnityEngine;
using System.Collections;

public class One : MonoBehaviour, Node {

	public static GameObject bird_object;
	public Player bird = new Player ("Bob", 0, 0, bird_object);
	public static GameObject owner_object;
	public Person owner = new Person("Owner", 0, 0, owner_object);
	public static GameObject bank_person_1_object;
	public Person bank_person_1 = new Person ("Joe", 0, 0, bank_person_1_object);
	public static GameObject bank_person_2_object;
	public Person bank_person_2 = new Person ("Bob", 0, 0, bank_person_2_object);
	public static GameObject bank_person_3_object;
	public Person bank_person_3 = new Person ("Lucy", 0, 0, bank_person_3_object);
	public static GameObject accomplice_object;
	public Person accomplice = new Person ("Accomplice", 0, 0, accomplice_object);
	public static GameObject first_letter_object;
	public Letter first_letter = new Letter("First Letter", 0, 0, first_letter_object);

	private string[] owner_phrases = new string[] {"Here, take this letter to my friend at the bank.","Take this letter.","Here's a letter."};
	private string[] bank_person_phrases = new string[] {"Hi there!","Oh look, a bird.","Ew, go away."};
	private string[] accomplice_phrases = new string[] {"Here, take this letter.","Take this letter.","Bring this letter to your owner."};

	void Start () {
		this.enabled = true;
	}
	
	void Update () {
		//Needs some if statements and stuff
		letter_to_inventory (first_letter);
		owner_speaks(owner, owner_phrases[Random.Range(0,owner_phrases.Length)]);
		bank_person_speaks (bank_person_1, bank_person_phrases [Random.Range (0, bank_person_phrases.Length)]);
		bank_person_speaks (bank_person_2, bank_person_phrases [Random.Range (0, bank_person_phrases.Length)]);
		bank_person_speaks (bank_person_3, bank_person_phrases [Random.Range (0, bank_person_phrases.Length)]);
		accomplice_speaks (accomplice, accomplice_phrases [Random.Range (0, accomplice_phrases.Length)]);
	}

	void letter_to_inventory(Person owner, Person bird, Mthing letter) {
		owner.remove_from_inventory (letter);
		bird.add_to_inventory (letter);
	}

	void owner_speaks(Person owner, string phrase) {
		owner.speak(phrase);
	}

	void bank_person_speaks(Person person, string phrase) {
		person.speak(phrase);
	}

	void accomplice_speaks(Person accomplice, string phrase) {
		accomplice.speak(phrase);
	}

}
