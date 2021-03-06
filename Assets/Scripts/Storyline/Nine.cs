﻿using UnityEngine;
using System.Collections;

public class Nine : MonoBehaviour, Node {
	public static GameObject display;

	public static GameObject bird_object;
	public Player bird = new Player ("Bob", 0, 0, bird_object, display);

	private string[] bird_phrases = new string[] {"Here, take this letter to my friend at the bank.","Take this letter.","Here's a letter."};

	void Start () {
		Nine.display = GameObject.FindWithTag("Player");
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
