using UnityEngine;
using System.Collections;

public class playerAttributes : MonoBehaviour {

	private static Player player;
	private static Storyline storyline;

	// Use this for initialization
	void Start () {
		player = new Player ("Bob",0,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
