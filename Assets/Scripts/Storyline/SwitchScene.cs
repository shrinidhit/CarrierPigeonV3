using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {

	public string sceneToSwitch;
		
	//Loading Building Scene if player goes into building.
	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject.name == "Player") {
			//Object.DontDestroyOnLoad(collider.gameObject);
			GameObject myplayer = GameObject.Find("World/PlayerGroup/Player");
			Object.Destroy(GameObject.Find("Setting"));
			Application.LoadLevelAdditive(sceneToSwitch);
			myplayer.transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
			if (sceneToSwitch != "City") {

			}
		}
	}
}
