using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour {

    public GameObject wave;
	public GameObject WaveSprite;
	
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
		GameObject.Instantiate (WaveSprite, _wave.transform.position, Quaternion.identity);
        
    }
}
