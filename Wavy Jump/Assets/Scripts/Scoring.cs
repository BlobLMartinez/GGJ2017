using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

    private int score;
    private float posPrece;

	// Use this for initialization
	void Start ()
    {
        posPrece = transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y > score)
        {
            score = (int)transform.position.y;
        }
    }

    void SetScore()
    {
        PlayerPrefs.SetInt("Player High Score", score);
    }
}
