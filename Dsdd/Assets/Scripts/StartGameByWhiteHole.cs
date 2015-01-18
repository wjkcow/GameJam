using UnityEngine;
using System.Collections;

public class StartGameByWhiteHole : MonoBehaviour {
	private AnimationClip animClp;
	private GameObject player;
	void Start() {
		animClp = Resources.Load("Rotate-shrink-reverse") as AnimationClip;
		// Instaniate the Gameplayer or get it 
		player = GameObject.FindGameObjectWithTag ("Player");

		if (!player.GetComponent<Animation>())
			player.AddComponent<Animation> ();
		// sync the position 
		player.transform.position = transform.position;

		player.animation.AddClip (animClp, "Rotate-shrink-reverse");
		// play
		gameObject.animation.Play ("Rotate-shrink-reverse");
		player.animation.Play ("Rotate-shrink-reverse");

		Destroy (gameObject, 1.0f);

	}
}
