using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {

	public string sceneToSwitch;
		
	//Loading Building Scene if player goes into building.
	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject.name == "Player") {
			Object.DontDestroyOnLoad(collider.gameObject);
			Application.LoadLevel(sceneToSwitch);	
		}
	}
}
