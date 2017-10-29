using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uimanager_level_mohammed : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.HasKey("blue") && PlayerPrefs.HasKey("green") ){
			Application.LoadLevel(Application.loadedLevel);
		
		}
		
	}
}
