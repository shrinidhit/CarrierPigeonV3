using UnityEngine;
using System.Collections;

public class Letter : Mthing {
	public static string messagedisplay;
	public static float messagetime;

	public string message;
	public GameObject display;
	public GameObject ldisplay;
	public GameObject location;

	public Letter(string name, int x, int y, string message, GameObject location)
		: base(name,x,y)
	{
		this.message = message;
		this.location = location;
		this.ldisplay = GameObject.Find("/World/PlayerGroup/LetterDisplay");
		this.display = GameObject.Find("/World/PlayerGroup/TextDisplay");
	}
	
	public override bool is_letter() {return true;}

	public void read_letter() {
		Letter.messagedisplay = this.message;
		Letter.messagetime = Time.time;
	}

	public void transfer_letter(GameObject oldloc, GameObject newloc) {
		if (this.location == oldloc) {
			this.location = newloc;
		}
		else {
			this.display.guiText.text = "You do not have access to transfer this letter";
		}
	}
}