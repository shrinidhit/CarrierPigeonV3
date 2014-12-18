using UnityEngine;
using System.Collections;

public class Seven : MonoBehaviour, Node {

	public Person owner;
	public Person bird;
	public Wobject money;
	
	// Use this for initialization
	void Start () {
		this.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void give_money_to_owner (Person owner, Person bird, Wobject money) {
		owner.add_to_inventory (money);
		bird.remove_from_inventory (money);
	}

	void owner_speaks (Person owner, string phrase) {
		//owner.say (phrase);
	}

	void end_story () {
		//?
	}
}
