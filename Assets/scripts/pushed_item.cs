using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pushed_item : MonoBehaviour {
	
	Rigidbody rb;


	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		if (!Physics.Raycast (transform.position, fwd, 1)) {
			rb.velocity = new Vector3 (0,0,0);
		
		}

		
	}
		
}
