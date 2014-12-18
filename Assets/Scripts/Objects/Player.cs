using UnityEngine;
using System.Collections;

public class Player : Person {

	public Player(string name, int x, int y, GameObject physical_rep)
		: base(name,x,y,physical_rep)
	{
		
	}
	
	public override bool is_player() {return true;}
}
