using UnityEngine;
using System.Collections;

public class One : MonoBehaviour, Node {
	// Use this for initialization

	public Person owner;
	public Person bird;
	public Person bank_person_1;
	public Person bank_person_2;
	public Person bank_person_3;
	public Person accomplice;
	public Wobject letter;

	private string[] owner_phrases = new string[] {"Here, take this letter to my friend at the bank.","Take this letter.","Here's a letter."};
	private string[] bank_person_phrases = new string[] {"Hi there!","Oh look, a bird.","Ew, go away."};
	private string[] accomplice_phrases = new string[] {"Here, take this letter.","Take this letter.","Bring this letter to your owner."};

	void Start () {
		this.enabled = true;
	}
	
	void Update () {

	}


	void letter_to_inventory(Person owner, Person bird, Wobject letter) {
		owner.remove_from_inventory (letter);
		bird.add_to_inventory (letter);
	}


	void owner_speaks(Person owner, string phrase) {
		//owner.say(phrase);
	}

	void bank_person_speaks(Person person, string phrase) {
		//person.say(phrase);
	}

	void accomplice_speaks(Person accomplice, string phrase) {
		//accomplice.say(phrase);
	}

}
