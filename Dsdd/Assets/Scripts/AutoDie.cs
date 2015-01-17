using UnityEngine;
using System.Collections;

public class AutoDie : MonoBehaviour {
	private float liveTime = 1.0f;
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
}
