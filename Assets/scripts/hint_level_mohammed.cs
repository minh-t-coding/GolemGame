using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint_level_mohammed : MonoBehaviour {
	public GameObject ani;
	// Use this for initialization
	void Start () {
		ani.SetActive (false);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}

	void OnTriggerEnter(){
		ani.SetActive (true);
		ani.GetComponent<Animator> ().Play ("hint_show_level_mohammed");
	
	}
	void OnTriggerExit(){
		ani.SetActive (false);
	}
}
