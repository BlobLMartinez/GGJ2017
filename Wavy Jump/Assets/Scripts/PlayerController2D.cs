using UnityEngine;
using System.Collections;
using JumpLib;

public class PlayerController2D : MonoBehaviour {

	public int speed;
    public float rayonMax;
    public GameObject rayon;

	private Vector2 _inputs;
	private Rigidbody2D rb2d;
    private Vector2 target;
    private Ray ray;
    private RaycastHit hit;

    void Start()
    {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update ()
    {

    }
    public void TouchOnScreen ()
    {
        target = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _inputs = -(target - (Vector2)transform.position);
        rb2d.velocity = _inputs * speed;
    }

    private void OnMouseDown()
    {
        Debug.Log("Box Clicked kgvsdbolwhdkvnc!");
        TouchOnScreen();
    }
}
