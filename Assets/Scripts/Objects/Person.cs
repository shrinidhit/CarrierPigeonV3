using UnityEngine;
using System.Collections;

public class Person : Mthing {

	ArrayList inventory;

	public Person(string name, int x, int y)
		: base(name,x,y)
	{
		this.inventory = inventory;
	}
	
	public override bool is_person() {return true;}

	public void add_to_inventory(Wobject item) {
		this.inventory.Add(item);
	}

	public void remove_from_inventory(string name) {
		foreach(Wobject item in this.inventory)
		{
			if (item.get_name() == name) {
				this.inventory.Remove(item);
			}
		}
	}
}