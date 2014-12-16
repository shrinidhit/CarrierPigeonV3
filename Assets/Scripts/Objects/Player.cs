using UnityEngine;
using System.Collections;

public class Player : Person {

	public Player(string name, int x, int y)
		: base(name,x,y)
	{
		
	}
	
	public override bool is_player() {return true;}
}
