using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SmoothCamera2D : MonoBehaviour
{

    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;

	//variables instantiation des murs
	public GameObject Wall;
	private float CameraYStart;


    void Start()
    {
        targetPos = transform.position;
		CameraYStart = transform.position.y;
    }
		
    void FixedUpdate()
    {
		//instanciation des murs
		if (transform.position.y > CameraYStart + 60) {
			GameObject.Instantiate (Wall, new Vector2 (10, transform.position.y), Quaternion.identity);
			GameObject.Instantiate (Wall, new Vector2 (-10, transform.position.y), Quaternion.identity);
			CameraYStart = transform.position.y;
		}

		if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;
            posNoZ.x = target.transform.position.x;

            Vector3 targetDirection = (target.transform.position - posNoZ);

            interpVelocity = targetDirection.magnitude * 5f;

            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);

        }
    }
}

