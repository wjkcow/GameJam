﻿using UnityEngine;
using System.Collections;

public class EntryNextLevel : MonoBehaviour {
	private AnimationClip animClp;
	public string levelname;
	// Use this for initialization
	void Start () {
		animClp = Resources.Load ("Rotate-shrink") as AnimationClip;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		GameObject tmp = other.gameObject;
		if (tmp.tag != "Player") {
			return;
		}
		if (!animClp)
			Debug.LogError ("animation not loaded");
		else if (other.tag == "Player"){
			// externally link animation
			tmp.AddComponent<Animation>();
			tmp.animation.AddClip (animClp, "Rotate-Shrink");
			tmp.animation.Play ("Rotate-Shrink");
			// enter next level now
			ChangeLevel (tmp);
		}
	}

	void ChangeLevel(GameObject player) {
		// do whatever need to do
		Debug.Log("Enter next level");
		Application.LoadLevel (levelname);

		// clear up !
	}
}
