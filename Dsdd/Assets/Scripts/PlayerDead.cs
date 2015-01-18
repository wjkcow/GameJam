using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

	private Animator anim;
	private bool isAlive = true;
	
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
		}
	}
	
	IEnumerator WaitAndPrint() {
		yield return new WaitForSeconds(2.0f);
		Destroy (this.gameObject);
		Application.LoadLevel (Application.loadedLevel);
	}
}
