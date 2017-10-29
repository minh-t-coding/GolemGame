using System.Collections;
using UnityEngine;


public class Charactermoving : MonoBehaviour {
	//private CharacterController controller;

	//private float verticalVelocity;
	//private float gravity = 25f;
	//private float jumpForce = 10f;

	public float speed = 10f;
	public float turnSpeed = 50f;

	private void Start(){
		controller = GetComponent<CharacterController>();
	}

	private void Update(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (-Vector3.forward * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.up, -speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector3.up, speed * Time.deltaTime);
		}
	}
}

/*
 using System.Collections;
using UnityEngine;


public class Charactermoving : MonoBehaviour {
	private CharacterController controller;

	private float verticalVelocity;
	private float gravity = 25f;
	private float jumpForce = 10f;

	public float speed = 10;

	private void Start(){
		controller = GetComponent<CharacterController>();
	}

	private void Update(){
		float x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		float z = Input.GetAxis ("Vertical") * speed * Time.deltaTime;


		if (controller.isGrounded) {
			verticalVelocity = -1 * Time.deltaTime;
			if (Input.GetButtonDown ("Jump")) {
				verticalVelocity = 20 * Time.deltaTime;
			}
		} else {
			//verticalVelocity -= 1 * Time.deltaTime;
			verticalVelocity -= Time.deltaTime;
		}

		Vector3 moveDelta = new Vector3 (x, verticalVelocity, z);
		transform.Rotate (Vector3.right, Time.deltaTime);
		transform.Rotate (Vector3.right, Time.deltaTime, Space.World);
		controller.Move (moveDelta);
	}
}
 */