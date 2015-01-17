using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float liveTime ;
	private bool immune = true;
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
		if (other.tag == "Transferable") {
			if(!immune){
				transferObject(other);
				createProtalEffect();
			}
		}
		if (other.tag != "Mirrow") {
			if (!immune) {
				Destroy(this.gameObject);
			}
		}
	}
	void OnTriggerExit2D(Collider2D other) {
		//print ("exit");
		immune = false;
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

	void createProtalEffect() {
		GameObject g = Instantiate (protalEffect, transform.position, Quaternion.identity) as GameObject;

	}
}
