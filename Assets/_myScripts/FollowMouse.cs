using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// LateUpdate is called after update
	void LateUpdate () {
		MatchMousePosition();
	}

	void MatchMousePosition(){
		Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		newPos.z = 0;
		transform.position = newPos;
	}
}
