using UnityEngine;
using System.Collections;

public class BlockReturn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 0) {
			Vector3 pos = transform.position;
			pos.x = -0.4f;
			transform.position = pos;
		}
	}
}
