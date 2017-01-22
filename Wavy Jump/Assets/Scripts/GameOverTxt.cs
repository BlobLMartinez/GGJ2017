using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTxt : MonoBehaviour {

	public playerDestroy GO;
	public SpriteRenderer Spr;


	void start () {

	}
	void Update () {

		if (GO.GameOver) {
			Spr.enabled = true;
			transform.position = new Vector2 (0, Camera.main.transform.position.y);
		}
	}

	public void TouchOnScreen ()
	{

		Debug.Log ("touched");
		if (Spr.enabled) {
			SceneManager.LoadScene ("Test");
		}
	}

	private void OnMouseDown()
	{
		TouchOnScreen();
	}
}
