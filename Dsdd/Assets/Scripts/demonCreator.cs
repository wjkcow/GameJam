using UnityEngine;
using System.Collections;

public class demonCreator : MonoBehaviour {
	
	public GameObject  demonPrefab;
	private GameObject gameObj;
	
	// Use this for initialization
	void Start () {
	}

	private int demonNum = 0;
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			for(; demonNum < 5; ++demonNum) {
				GameObject gameObj = Instantiate (demonPrefab) as GameObject;
				Vector3 pos = this.transform.position;
				pos.y += 3f;
				pos.x += demonNum - 1.5f;
				gameObj.transform.position = pos;
			}
		}
	}
}
