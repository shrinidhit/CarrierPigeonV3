using UnityEngine;
using System.Collections;

public class Positioning : MonoBehaviour {
	// Use this for initialization
	private GameObject player;
	void Start () {
		this.player = GameObject.Find("/PlayerGroup/Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerposition = this.player.transform.position;
		Vector3 offset = this.player.transform.right + player.transform.up;
		transform.position = playerposition;
	}
}
