using UnityEngine;
using System.Collections;

public class Letter : Mthing {

	public Letter(string name, int x, int y)
		: base(name,x,y)
	{
		
	}
	
	public override bool is_letter() {return true;}
}