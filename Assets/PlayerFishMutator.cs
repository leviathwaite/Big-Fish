using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// used to build player's fish's features
// TODO control sizes here? (scale) or should it be done in animator

public class PlayerFishMutator : MonoBehaviour {

	public int mutationLevel = 0;
	public int fishSize = 0;

	public int startingMutatioinLevel;
	public int startingSize;

	public float scaleScaler = 0.1f;

	// Use this for initialization
	void Start () {
		mutationLevel = startingMutatioinLevel;
		fishSize = startingSize;
	}
	
	// Update is called once per frame
	void Update () {
		// TODO remove, for testing
		if(Input.GetKeyUp(KeyCode.Space)){

			IncreaseFishSize();
		}
	}

	void IncreaseFishSize(){
		fishSize ++;
		// TODO modify scale/render size
		SetScaleToFishSize();
	}

	void DecreaseFishSize(){
		fishSize--;
	}

    // TODO create a scalers for scale
	void SetScaleToFishSize(){
		float newScale = fishSize * scaleScaler;
		if(newScale < 1) newScale = 1;
		transform.localScale = new Vector3(newScale, newScale, newScale);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Fish")){
			Debug.Log("Hit a fish");

			// check fish size
			EnemyFishSize enemyFish = other.GetComponent<EnemyFishSize>();
			if(enemyFish != null){
				if(fishSize >= enemyFish.CurrentFishSize){
					// Player fish is larger
					Debug.Log("Yum");
					IncreaseFishSize();
				}else{
					// enemy fish larger
					Debug.Log("Ouch");
					// TODO what should we Do here? decrease size or die???
				}
			}
		}
        Debug.Log ("Trigger Entered");
}
}
