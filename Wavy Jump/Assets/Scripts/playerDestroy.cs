using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDestroy : MonoBehaviour {

	public bool GameOver = false;
	public float GOThreshold = 8;

	void Update() {
		if (Camera.main.transform.position.y - gameObject.transform.position.y  > GOThreshold) {
			GameOver = true;
		} 
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "KillZone") {
			
			GameOver = true;
		}
	}

}
