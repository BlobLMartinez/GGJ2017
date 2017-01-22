using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {

	public float destroyDistance;

	void Update () {
		if (Camera.main.transform.position.y - gameObject.transform.position.y > destroyDistance) {
			Destroy (gameObject);
		}
			
	}
}
