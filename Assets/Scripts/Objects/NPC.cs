using UnityEngine;
using System.Collections;

public class NPC : Person {

	public NPC(string name, int x, int y)
		: base(name,x,y)
	{
		
	}
	
	public override bool is_npc() {return true;}
}
