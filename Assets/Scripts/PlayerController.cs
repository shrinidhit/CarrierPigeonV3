using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public float rotSensitivity = 90;

	void FixedUpdate() 
	{
	//Get Forward Motions:
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 forward = moveVertical * transform.forward;
		Vector3 right = moveHorizontal * transform.right;
		Vector3 movement = forward + right;

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

	//Make Player Invisible:
		//renderer.enabled = false;

	//Moving:
		rigidbody.freezeRotation = true;
		rigidbody.AddForce (movement * speed * Time.deltaTime);

	//Flying:
		if (Input.GetKey (KeyCode.W)) {
			rigidbody.AddForce (-3f * rigidbody.mass * Physics.gravity * Time.deltaTime);
			print("Flying");
			//counter gravity
		}
	}

	//void OnCollisionEnter(Collision collision) {
		//print(collision.gameObject.name);
	//}
}