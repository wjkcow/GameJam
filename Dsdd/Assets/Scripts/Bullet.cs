using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float liveTime ;
	private int immune = 2;
	public float projectSpeed = 0.5f;
	public GameObject protalEffect;
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
		if (other.tag == "Transferable" || other.tag == "Player") {
			if(immune == 0){
				transferObject(other);
				createProtalEffect();
			}
		}
		if (other.tag != "Mirrow") {
			if (immune == 0) {
				Destroy(this.gameObject);
			}
		}
	}
	void OnTriggerStay2D(Collider2D other){
		OnTriggerEnter2D (other);
	}
	void OnTriggerExit2D(Collider2D other) {
		//print ("exit");
		if (other.tag == "Player") {
			immune--;

		}
	}

	void transferObject(Collider2D other){
		Globals g = GameObject.Find("Global").GetComponent<Globals>();
		Vector3 velOther = other.transform.rigidbody2D.velocity;
		float vel = velOther.magnitude;
		velOther = vel * g.doorDirection + projectSpeed * g.doorDirection;
		other.transform.rigidbody2D.velocity = velOther;
		other.transform.position = g.door.transform.position;
		print (g.transform.position);
	}

	void createProtalEffect() {

		GameObject g = Instantiate (protalEffect, transform.position, Quaternion.identity) as GameObject;
		print (g);

	}
}
