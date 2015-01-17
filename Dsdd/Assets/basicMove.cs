using UnityEngine;
using System.Collections;

public class basicMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			print ("leftArrow");
			transform.rigidbody2D.velocity = new Vector2 (-1,0);
			
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			print ("rightArrow");
			transform.rigidbody2D.velocity = new Vector2 (1,0);
		} else if (Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow)) {
			transform.rigidbody2D.velocity = new Vector2 (0,0);
		}
	}
}
