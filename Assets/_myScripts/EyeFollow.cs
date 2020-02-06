using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollow : MonoBehaviour {

	// TODO FIXME

	public Transform target;
	private float prevAngle = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		LookAt2D();
	}

	

	void LookAt2D(){

		Vector3 direction = target.position - transform.position; // normalize??
		// get angle. NOTE atan2(y, x) returns Radians
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		// try to stop shake, might have to use smoothing on angle
		/*
		if(prevAngle >= ){

		}
		*/
		// convert to quaternion
		Quaternion newRotation = Quaternion.AngleAxis(angle, Vector3.forward);
		// apply rotation
		transform.rotation = newRotation;


		// Draw line to target in sceneview
		Debug.DrawLine(transform.position, target.position, Color.red);
	}
}
