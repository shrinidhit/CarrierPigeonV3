using UnityEngine;
using System.Collections;

public class Eight : MonoBehaviour, Node {

	public Person police;
	public Person bird;
	public Wobject money;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void police_speaks (Person police, string phrase) {
		//police.say(phrase);
	}

	void police_takes_money (Person police, Person bird, Wobject money) {
		police.add_to_inventory (money);
		bird.remove_from_inventory (money);
	}

	void end_story() {
		//?
	}

}
