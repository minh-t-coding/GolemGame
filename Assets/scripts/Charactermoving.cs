using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermoving : MonoBehaviour {

	private Rigidbody rb;
	public GameObject dragged;

	[SerializeField]
	public float movingspeed;
	Collider col;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		col = GetComponent<Collider> ();


		
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		//if (Input.GetKey(KeyCode.UpArrow) or Input.GetKey(KeyCode.LeftArrow) or Input.GetKey(KeyCode.RightArrow) ){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * movingspeed;


	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "dragged") {
			rb.velocity = new Vector3(0f, 3000f, 0f);
		
		}
	
	}
}
