using UnityEngine;
using System.Collections;

public class Mirrow : MonoBehaviour {
	public Vector2 reflectDir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Bullet_b" || other.tag == "Bullet_w") {
			print ("Bullet hit");
			Vector2 otherSpeed = other.rigidbody2D.velocity;
			Vector2 reflectSpeed = otherSpeed -
				2.0f * reflectDir.normalized * (Vector2.Dot(otherSpeed, reflectDir.normalized));
			print (otherSpeed);
			print (reflectSpeed);
			other.rigidbody2D.velocity = reflectSpeed;
		}
	}
}
