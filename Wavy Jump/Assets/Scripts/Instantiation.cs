using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour {

    public GameObject wave;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            kaboum();
        }
	}

    void kaboum()
    {
        GameObject _wave = (GameObject)Instantiate(wave, (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        
    }
}
