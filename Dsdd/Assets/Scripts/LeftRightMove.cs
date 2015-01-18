using UnityEngine;
using System.Collections;

public class LeftRightMove : MonoBehaviour {

	private float changeInterval;

	void Start () {
		changeInterval = Time.time;
		rigidbody2D.velocity = new Vector2 (1, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if ( Time.time - changeInterval > 3.0f) {
			changeInterval = Time.time;

			rigidbody2D.velocity = -rigidbody2D.velocity;  

		}

	}
}
