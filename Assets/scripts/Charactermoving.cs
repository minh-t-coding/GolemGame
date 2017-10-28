using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermoving : MonoBehaviour {

	private Rigidbody rb;
	public float pushPower = 2.0F;

	[SerializeField]
	public float movingspeed;
	Collider col;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();



	
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		float moveHirozental = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHirozental,0,moveVertical);
		rb.velocity = movement * movingspeed;

	
	}
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Water") {
			Destroy (col.gameObject);
		}
	}
}
