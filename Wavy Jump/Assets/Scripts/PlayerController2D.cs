using UnityEngine;
using System.Collections;
using JumpLib;

public class PlayerController2D : MonoBehaviour {

	public int speed;

	private Vector2 _inputs;
	private Rigidbody2D rb2d;
    private Vector2 target;

	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            target = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform.position = Vector2.Lerp(transform.position, target, (float)speed);
            _inputs = - (target - (Vector2)transform.position);
            rb2d.velocity = _inputs * speed;
        }
        

    }
}
