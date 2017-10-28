using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	public static int plates;

	void OnTriggerEnter(Collider other){
		if (other.CompareTag("rock")) {
			plates++;
			Debug.Log (plates);
		}
		//plates++;
		//Debug.Log (plates);
		//Destroy (other.gameObject);
	}

	public static int getPlates (){
		return plates;
	}
}
