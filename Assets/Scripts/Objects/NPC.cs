using UnityEngine;
using System.Collections;

public class NPC : Person {

	public NPC(string name, int x, int y, GameObject physical_rep)
		: base(name,x,y,physical_rep)
	{
		
	}
	
	public override bool is_npc() {return true;}
}
