using UnityEngine;
using System.Collections;

public class demonCreator : MonoBehaviour {
	
	public GameObject  demonPrefab;
	private GameObject gameObj;
	
	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			for(int i=0; i<3; ++i) {
				GameObject gameObj = Instantiate (demonPrefab) as GameObject;
				Vector3 pos = this.transform.position;
				pos.y += 3f;
				pos.x += i - 1.5f;
				gameObj.transform.position = pos;
			}
		}
	}
}
