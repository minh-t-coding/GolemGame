using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Trigger.getPlates () == 1) {
			Debug.Log ("Open");
			Destroy(gameObject);
		}
	}
}
