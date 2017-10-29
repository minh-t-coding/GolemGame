using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_puzzle : MonoBehaviour {
	
	public string tag_assigned;
	public string cube_name;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag== tag_assigned){

			PlayerPrefs.SetString (cube_name,"true");
		}
		
	}
}
