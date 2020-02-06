using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	Vector3 newPos;

	// Use this for initialization
	void Start () {
		newPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// assign current position to newPos or wrap screen won't work
		newPos = transform.position;

		newPos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		newPos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

		transform.position = newPos;
	}
}
