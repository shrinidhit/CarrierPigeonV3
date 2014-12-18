using UnityEngine;
using System.Collections;

public class Wobject{
	int x;
	int y;
	string name;
	GameObject physical_rep;

	public Wobject(int x, int y) {
		this.x = x;
		this.y = y;
	}

	public Wobject(string name, int x, int y, GameObject physical_rep) {
		this.physical_rep = physical_rep;
		this.name = name;
		this.x = x;
		this.y = y;
	}

	public virtual string get_name() {return this.name;}
	public virtual GameObject get_object() {return this.physical_rep;}
	public virtual bool is_mthing() {return false;}
	public virtual bool is_letter() {return false;}
	public virtual bool is_building() {return false;}
	public virtual bool is_person() {return false;}
	public virtual bool is_player() {return false;}
	public virtual bool is_npc() {return false;}
}
