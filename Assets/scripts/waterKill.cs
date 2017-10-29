using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterKill : MonoBehaviour {
	[SerializeField]
	float x;
	[SerializeField]
	float y;
	[SerializeField]
	float z;
	public GameObject Rocko;
	// Use this for initialization
	void Start () {
		x = -80f;
		y = 0f;
		z = 0f;
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.CompareTag("Player")) {
			
			col.gameObject.transform.position = new Vector3 (x,y,z);


			//Destroy(col.gameObject);
		}
	}
}
