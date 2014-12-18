using UnityEngine;
using System.Collections;

public class playerAttributes : MonoBehaviour {
	public GameObject display;
	private Player player;
	public GameObject player_object;
	private Storyline storyline;

	// Use this for initialization
	void Start () {
		this.player = new Player ("Bob",0,0, player_object, display);
		this.storyline = new Storyline();
		this.player.speak("Welcome to the Game");
		this.display = GameObject.FindWithTag("Player");
		

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time <= this.player.spokentime + 5.0f) {
			this.player.display.SetActive (true);
		} 
		else {
			this.player.display.SetActive (false);
		}
	}
}
