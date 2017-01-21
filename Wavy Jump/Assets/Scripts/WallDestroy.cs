using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour {




	void Update () {

		if (Camera.main.transform.position.y - transform.position.y > 90) {
			Destroy (gameObject);
			Debug.Log("WallDestroy");

		}

	}
}
