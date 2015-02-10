using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

	private Animator anim;
	private bool isAlive = true;
	public AudioClip NewMusic;

	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -5  )
			playerDead ();
	}

	
	public void playerDead()
	{
		if (isAlive) 
		{
			isAlive = false;
			this.rigidbody2D.velocity *= 0;
			this.rigidbody2D.gravityScale = 0.0f;
			StartCoroutine(WaitAndPrint());
			anim.SetBool("isAlive", false);
			// disable control
		}
	}
	
	IEnumerator WaitAndPrint() {
		//		GameObject go = GameObject.Find("Game Music"); //Finds the game object called Game Music, if it goes by a different name, change this. 
		this.audio.clip = NewMusic; 
		//Replaces the old audio with the new one set in the inspector. 
		this.audio.PlayOneShot(NewMusic); //Plays the audio.

		yield return new WaitForSeconds(3.5f);
		Destroy (this.gameObject);
		Application.LoadLevel (Application.loadedLevel);
	}
}
