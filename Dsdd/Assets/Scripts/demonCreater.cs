using UnityEngine;
using System.Collections;

public class demonCreater : MonoBehaviour {

	public GameObject  demonPrefab;
	private GameObject gameObj;
	private int demonNum = 0;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Time.frameCount % 25 == 0) {
			GameObject gameObj = Instantiate (demonPrefab) as GameObject;
			Vector3 pos = this.transform.position;
			gameObj.transform.position = pos;
			demonNum++;
		}
		if(demonNum >= 3)
			Destroy(this.gameObject);
	}
}
