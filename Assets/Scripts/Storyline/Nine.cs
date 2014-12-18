using UnityEngine;
using System.Collections;

public class Nine : MonoBehaviour, Node {

	public GameObject bird_object;
	public Player bird = new Player ("Bob", 0, 0, bird_object);

	private string[] bird_phrases = new string[] {"Here, take this letter to my friend at the bank.","Take this letter.","Here's a letter."};

	void Start () {
		this.enabled = false;
	}

	void Update () {
		//Needs some if statements and stuff
		player_speaks (bird, bird_phrases [Random.Range (0, bird_phrases.Length)]);
	}

	void player_speaks(Person bird, string phrase) {
		bird.speak(phrase);
	}
}
