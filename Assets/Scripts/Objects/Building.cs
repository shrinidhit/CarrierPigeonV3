using UnityEngine;
using System.Collections;

public class Building : Wobject {

	public Building(string name, int x, int y)
		: base(name,x,y)
	{
		
	}
	
	public override bool is_building() {return true;}
}