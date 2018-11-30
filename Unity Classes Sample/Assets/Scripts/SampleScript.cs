using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour {

	void Greet() {
		Debug.Log("Hello, world!");
	}

	string Concat(string a, string b) {
		return a + b;
	}
	
	// Use this for initialization
	void Start () {
		Greet();
		Debug.Log(Concat("KIT", "CC"));
		Debug.Log(StaticVars.GetMessage());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
