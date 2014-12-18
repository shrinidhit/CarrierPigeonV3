using UnityEngine;
using System.Collections;

public class Four : MonoBehaviour, Node {


	public Person owner;
	public Person bird;
	public Person accomplice;
	public Wobject letter;

	private Vector3[] accomplice_locations = new Vector3[] {new Vector3(0.0f,0.0f,0.0f),new Vector3(0.1f,0.1f,0.1f)};



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}





	void owner_speaks (Person owner, string phrase) {
		//owner.say(phrase);
	}

	void letter_to_inventory (Person owner, Person bird, GameObject letter) {
		owner.remove_from_inventory (letter);
		bird.add_to_inventory (letter);

	}

	void bank_person_speaks (Person person, string phrase) {
		//person.say(phrase);
	}

	void accomplice_runs (GameObject accomplice, Vector3 location) {
		accomplice.transform.position = location;
	}
}
