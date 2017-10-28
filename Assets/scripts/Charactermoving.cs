using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermoving : MonoBehaviour {

	private Rigidbody rb;
	public GameObject dragged;
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
		//if (Input.GetKey(KeyCode.UpArrow) or Input.GetKey(KeyCode.LeftArrow) or Input.GetKey(KeyCode.RightArrow) ){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * movingspeed;


	}

	void OnControllerColliderHit(ControllerColliderHit hit){
			Rigidbody body = hit.collider.attachedRigidbody;
			if (body == null || body.isKinematic)
				return;

			Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
			body.velocity = pushDir * pushPower;

		}
	
	}

