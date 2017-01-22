using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody_Disabler : MonoBehaviour {

	public playerDestroy GameOverScript;
	public Rigidbody2D[] RBArr;

	void Update () {
		
		if (GameOverScript.GameOver) {

			foreach (Rigidbody2D child in RBArr) {
					
				child.velocity = Vector2.zero; 
				child.angularVelocity = 0f;
				child.gravityScale = 0f;
			}

		}
	}
}
