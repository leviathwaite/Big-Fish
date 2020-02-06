using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaintainStartingRotation : MonoBehaviour {
	// Variable to store starting rotation
	private Quaternion startingRotation;

	// Use this for initialization
	void Start () {
		// get starting rotation
		startingRotation = transform.rotation;
	}
	
	// LateUpdate is called after Update();
	void LateUpdate () {
		// set rotation to starting rotation
		transform.rotation = startingRotation;
	}
}
