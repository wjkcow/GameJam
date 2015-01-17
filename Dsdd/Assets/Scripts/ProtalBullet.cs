using UnityEngine;
using System.Collections;

public class ProtalBullet : MonoBehaviour {
	public float liveTime ;
	public float immuneTime;

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
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Protalable") {
			Vector3 portalDir = other.GetComponent<CellDir>().dir;
			openProtal(portalDir);
		}
		if (immuneTime + startTime < Time.time) {
			print ("Destroy");
			Destroy(this.gameObject);
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
