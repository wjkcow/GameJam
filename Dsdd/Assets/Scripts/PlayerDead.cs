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

	}

	
	public void playerDead()
	{
		if (isAlive) 
		{
			isAlive = false;
			StartCoroutine(WaitAndPrint());
			anim.SetBool("isAlive", false);
		}
	}
	
	IEnumerator WaitAndPrint() {
		yield return new WaitForSeconds(2.0f);
		Destroy (this.gameObject);
	}
}
