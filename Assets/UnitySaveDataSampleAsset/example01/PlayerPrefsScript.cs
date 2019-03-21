using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsScript : MonoBehaviour {

	private GameObject cube;

	// Use this for initialization
	void Start () {
		cube = GameObject.Find ("Cube");
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs playerPrefs = new PlayerPrefs ();
	}
}
