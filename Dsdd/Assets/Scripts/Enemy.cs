using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float speed = 2;
	public Vector2 dir;
	public bool onGround = false;
	public GameObject dieEffect;
	// Use this for initialization
	void Start () {
		dir = new Vector2 (-1, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (onGround)
			transform.rigidbody2D.velocity = dir * speed;

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "sprSpike") {
			Instantiate(dieEffect, transform.position, Quaternion.identity);
			Destroy(this.gameObject);		
		} else if (other.tag == "Player"){
			//Game over Scene
			Destroy(other.gameObject);
		} else if (other.tag == "Bullet_b"){
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

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "Ground") {
			print ("off ground");
			onGround = false;
		}
	}
}
