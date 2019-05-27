using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMe : MonoBehaviour {

	public float delMe;


	void Update () {
		delMe -= Time.deltaTime;
		if (delMe <= 0) {
			Destroy (gameObject);
		}
	}
}
