using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {

	void Update () {
		if (Camera.main.transform.position.y - gameObject.transform.position.y > 25) {
			Destroy (gameObject);
		}
			
	}
}
