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
		if (Input.GetKey(KeyCode.UpArrow)){
		Vector3 movement = new Vector3 (0,0,1f);
		rb.velocity = movement * movingspeed;
			Invoke ("stop_moving",0.001f);
			transform.Rotate (0,0,-180f);
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			Vector3 movement = new Vector3 (0,0,-1f);
			rb.velocity = movement * movingspeed;
			Invoke ("stop_moving",0.001f);
			transform.Rotate (0,0,-180f);
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			Vector3 movement = new Vector3 (1f,0,0);
			rb.velocity = movement * movingspeed;
			Invoke ("stop_moving",0.001f);
			transform.Rotate (0,0,-180f);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			Vector3 movement = new Vector3 (-1f,0,0);
			rb.velocity = movement * movingspeed;
			Invoke ("stop_moving",0.001f);
			transform.Rotate (0,0,180f);
		}

		}
	void stop_moving (){
		rb.velocity = new Vector3 (0,0,0);
	
	}
	
	}

