using UnityEngine;
using System.Collections;

public class Player : Person {

	public Player(string name, int x, int y, GameObject physical_rep, GameObject display)
		: base(name,x,y,physical_rep, display)
	{
		
	}
	
	public override bool is_player() {return true;}
}
