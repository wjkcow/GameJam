using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float speed = 2;
	public Vector2 dir;
	public bool onGround = true;
	// Use this for initialization
	void Start () {
		dir = new Vector2 (1, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (onGround)
			transform.rigidbody2D.velocity = dir * speed;

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Spike") {
			Destroy(this.gameObject);		
		} else if (other.tag == "Player"){
			//Game over Scene
			Destroy(other.gameObject);
		} else if (other.tag == "Bullet"){
			print ("hit");
			onGround = false;
			transform.rigidbody2D.velocity = new Vector2 (0,0);
		} else if (other.name == "Ground"){
			onGround = true;
		} else {
			print ("change dir");
			dir = -1 * dir;
		}
	} 
}
