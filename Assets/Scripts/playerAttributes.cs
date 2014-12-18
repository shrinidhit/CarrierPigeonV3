using UnityEngine;
using System.Collections;

public class playerAttributes : MonoBehaviour {

	private Player player;
	public GameObject player_object;
	private Storyline storyline;
	public GameObject player_object;

	// Use this for initialization
	void Start () {
		this.player = new Player ("Bob",0,0, player_object);
		this.storyline = new Storyline();
		this.player.speak("Welcome to the Game");

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
