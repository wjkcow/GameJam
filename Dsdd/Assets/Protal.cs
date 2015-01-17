using UnityEngine;
using System.Collections;

public class Protal : MonoBehaviour {
	public GameObject gVal;
	private Vector3 doorDir;

	void Start () {
		transform.rigidbody2D.velocity = new Vector2 (1, 0);
	} 


	void OnTriggerEnter2D(Collider2D other){
		GameObject g = GameObject.Find("Global");
		Vector3 velOther = other.transform.rigidbody2D.velocity;
		float vel = velOther.magnitude;
		velOther = vel * doorDir;
		other.transform.position = g.GetComponent<global>().door.transform.position;
		print (g.transform.position);
	}
}
