using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float speed = 2;
	private Vector3 newPos;

	// Use this for initialization
	void Start () {
		newPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		newPos = transform.position;
		newPos.x += speed * Time.deltaTime;
		newPos.y = Mathf.Sin(Time.time);
		transform.position = newPos;
		
	}
}
