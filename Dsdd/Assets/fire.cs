using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	public GameObject cubePrefabVar;
	public GameObject global;
	private float time ;
	// Use this for initialization
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > time + 1.0f){
			Instantiate (cubePrefabVar);
			time = Time.time;
		}
	}
}
