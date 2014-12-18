using UnityEngine;
using System.Collections;

public class Seven : MonoBehaviour, Node {
	public static GameObject display;

	public static GameObject bird_object;
	public Player bird = new Player ("Bob", 0, 0, bird_object, display);

	public static GameObject owner_object;
	public Person owner = new Person ("Owner", 0, 0, owner_object, display);

	public static GameObject money_object;
	public Mthing money = new Mthing("Money", 0, 0, money_object);

	private string[] owner_phrases = new string[] {"Here, take this letter to my friend at the bank.","Take this letter.","Here's a letter."};

	void Start () {
		Seven.display = GameObject.FindWithTag("Player");
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		give_money_to_owner (owner, bird, money);
		owner_speaks(owner, owner_phrases[Random.Range(0,owner_phrases.Length)]);
		end_story ();

	}

	void give_money_to_owner (Person owner, Person bird, Mthing money) {
		owner.add_to_inventory (money);
		bird.remove_from_inventory (money);
	}

	void owner_speaks (Person owner, string phrase) {
		owner.speak(phrase);
	}

	void end_story () {
		//?
	}
}
