using UnityEngine;
using System.Collections;

public class ProtalBullet : MonoBehaviour {
	public float liveTime ;
	private int immune = 2;

	public GameObject protalPrefab;
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
	void OnTriggerStay2D(Collider2D other){
		OnTriggerEnter2D (other);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Protalable") {
			Vector3 portalDir = other.GetComponent<CellDir>().dir;
			openProtal(portalDir);
		}
		// print (transform.position);
		if (other.tag == "HelpTrigger") {
			return;
		}
		if (other.tag != "Mirrow") {
			if (immune == 0) {
				Destroy(this.gameObject);
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D other) {
		//print ("exit");
		if (other.tag == "Player") {
			immune--;
		}
	}
	void openProtal(Vector3 dir){
		GameObject newProtal =  (GameObject)Instantiate (protalPrefab, transform.position, Quaternion.identity);
		Globals g = GameObject.Find("Global").GetComponent<Globals>();
		Destroy (g.door);
		g.door = newProtal;
		g.doorDirection = dir;
	}
}
