using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[SerializeField]
	Transform player;
	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = player.position - transform.position;
	}
	
	void FixedUpdate(){
		Vector3 currentpos = transform.position;
		Vector3 newpos = player.position - offset;
		transform.position = Vector3.Lerp (currentpos,newpos,5.1f);


	} 
}
