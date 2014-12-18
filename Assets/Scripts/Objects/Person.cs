using UnityEngine;
using System.Collections;
using System.Timers;

public class Person : Mthing {

	public ArrayList inventory;
	public GameObject display;
	public GameObject physical_rep;
	public float spokentime;

	public Person(string name, int x, int y, GameObject physical_rep, GameObject display)
		: base(name,x,y,physical_rep)
	{
		//Inventory
		this.inventory = inventory;
		//GUI Text 

		this.physical_rep = physical_rep;
		this.display = display;
		this.display.SetActive (false);
		this.spokentime = 0.0f;
	}
	
	public override bool is_person() {return true;}

	public void add_to_inventory(Wobject item) {
		this.inventory.Add(item);
	}

	public void remove_from_inventory(Wobject item) {
		foreach(Wobject thing in this.inventory)
		{
			if (thing.get_name() == item.get_name()) {
				this.inventory.Remove(thing);
			}
		}
	}

	public void speak(string sentence) {
		this.display.guiText.text = sentence;	
		this.spokentime = Time.time;
	}
}