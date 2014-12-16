using UnityEngine;
using System.Collections;

public class Person : Mthing {

	public Person(string name, int x, int y)
		: base(name,x,y)
	{
		
	}
	
	public override bool is_person() {return true;}
}
