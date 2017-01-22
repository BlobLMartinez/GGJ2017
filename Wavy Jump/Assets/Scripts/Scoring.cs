using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

    private int score;
    private float posPrece;
	public GUIText ScoreTxt;

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
		ScoreTxt.text = score.ToString ();
    }

    void SetScore()
    {
        PlayerPrefs.SetInt("Player High Score", score);
    }
}
