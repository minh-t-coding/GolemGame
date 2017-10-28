using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderPhysics : MonoBehaviour {
	Rigidbody rb;
	GameObject hitter;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 fwd = transform.TransformDirection (Vector3.forward);

	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("stopper")) {
			rb.velocity = new Vector3 (0,0,0);
		}
	}
}
