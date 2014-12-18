using UnityEngine;
using System.Collections;

public class Mthing: Wobject{
	
	public Mthing(string name, int x, int y, GameObject physical_rep)
		: base(name,x,y,physical_rep)
	{

	}

	public override bool is_mthing() {return true;}
}