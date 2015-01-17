﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float liveTime ;
	public float immuneTime;
	public float projectSpeed = 0.5f;
	private float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (liveTime + startTime < Time.time) {
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Transferable") {
			transferObject(other);
		}
		if (immuneTime + startTime < Time.time) {
			Destroy(this.gameObject);
		}
	}


	void transferObject(Collider2D other){
		Globals g = GameObject.Find("Global").GetComponent<Globals>();
		Vector3 velOther = other.transform.rigidbody2D.velocity;
		float vel = velOther.magnitude;
		velOther = vel * g.doorDirection + projectSpeed * g.doorDirection.normalized;
		other.transform.rigidbody2D.velocity = velOther;
		other.transform.position = g.door.transform.position;
		print (g.transform.position);
	}
}