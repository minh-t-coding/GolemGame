using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Charactermoving : MonoBehaviour {
	private Rigidbody rb;
	public float pushPower = 2.0F;

	[SerializeField]
	public float movingspeed;
	Collider col;
	public bool is_ground;
	[SerializeField]
	float jumpingforce;


	// Use this for initialization
	void Start () {
		is_ground = true;
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{	/*if (!Physics.Raycast(transform.position,Vector3.down)){
			is_ground = true;
		}*/
		rb.AddForce (0f, -400f, 0f);
		float moveHirozental = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHirozental, 0, moveVertical);
		rb.velocity = movement * movingspeed;

		if (Input.GetKey (KeyCode.D)) {
			transform.rotation = Quaternion.Euler (0, 180, 0);
		} 
		if (Input.GetKey (KeyCode.A)) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.rotation = Quaternion.Euler (0, 270, 0);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.rotation = Quaternion.Euler (0, 90, 0);
		}
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.W)) {
			transform.rotation = Quaternion.Euler (0, 45, 0);
		}
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S)) {
			transform.rotation = Quaternion.Euler (0, 315, 0);
		}
		if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.W)) {
			transform.rotation = Quaternion.Euler (0, 135, 0);
		}
		if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.S)) {
			transform.rotation = Quaternion.Euler (0, 225, 0);
		}
		if (Input.GetKey (KeyCode.Space) && is_ground) {
			rb.AddForce (0f, jumpingforce, 0f);
			// = false;
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Water") {
			Destroy (col.gameObject);
		}
	}
}

	
