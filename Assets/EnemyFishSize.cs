using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// stores the size of enemy fish and is called on collision with player fish(from PlayerFishMutator)

public class EnemyFishSize : MonoBehaviour {

	int fishSize;
	public int startingFishSize = 0;

	// Use this for initialization
	void Start () {
		fishSize = startingFishSize;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int CurrentFishSize
    {
        get 
        { 
           return fishSize; 
        }
    }
}
