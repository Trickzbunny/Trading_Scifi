using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	Camera myCam;

	// Use this for initialization
	void Start () {
		myCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (myCam.transform);
	}
}
