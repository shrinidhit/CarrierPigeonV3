using UnityEngine;
using System.Collections;

public class Building : Wobject {

	public Building(string name, int x, int y, GameObject physical_rep)
		: base(name,x,y,physical_rep)
	{
		
	}
	
	public override bool is_building() {return true;}
}