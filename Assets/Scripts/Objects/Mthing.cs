using UnityEngine;
using System.Collections;

public class Mthing: Wobject{
	
	public Mthing(string name, int x, int y)
		: base(name,x,y)
	{

	}

	public override bool is_mthing() {return true;}
}