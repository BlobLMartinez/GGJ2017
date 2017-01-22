using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveDestroy : MonoBehaviour {


	void Start () {
		StartCoroutine (Timer ());
	}

	IEnumerator Timer() {
		yield return new WaitForSeconds (2);
		Destroy (gameObject);
	}
}
