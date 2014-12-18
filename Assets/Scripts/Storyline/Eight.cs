using UnityEngine;
using System.Collections;

public class Eight : MonoBehaviour, Node {

	public static GameObject bird_object;
	public static GameObject display;
	public Player bird = new Player ("Bob", 0, 0, bird_object, display);
	public static GameObject police_object;
	public Person police = new Person("Police", 0, 0, police_object, display);
	public static GameObject money_object;
	public Mthing money = new Mthing("Money", 0, 0, money_object);

	private string[] police_phrases = new string[] {"Here, take this letter to my friend at the bank.","Take this letter.","Here's a letter."};

	void Start () {
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		police_speaks (police, police_phrases [Random.Range (0, police_phrases.Length)]);
		police_takes_money (police, bird, money);
		end_story ();	
	}

	void police_speaks (Person police, string phrase) {
		police.speak(phrase);
	}

	void police_takes_money (Person police, Person bird, Mthing money) {
		police.add_to_inventory (money);
		bird.remove_from_inventory (money);
	}

	void end_story() {
		//?
	}

}
