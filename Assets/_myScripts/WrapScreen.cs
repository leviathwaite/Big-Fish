using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapScreen : MonoBehaviour {

	public Vector3 bounds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckBounds();
	}

	void CheckBounds(){
		Vector3 newPos = transform.position;
		if(transform.position.x > bounds.x || transform.position.x < -bounds.x){
			// wrap around horizontal
			newPos.x = -newPos.x;
		}

		if(transform.position.y > bounds.y || transform.position.y < -bounds.y){
			// wrap around vertical
			newPos.y = - newPos.y;
		}

		// apply
		transform.position = newPos;
	}
}
