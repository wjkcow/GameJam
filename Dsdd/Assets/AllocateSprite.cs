using UnityEngine;
using System.Collections;

public class AllocateSprite : MonoBehaviour {
	private GameObject childSpriteRender;
	public Sprite renderPic;
	// Use this for initialization
	private int items;
	void Start () {

		float local_y = gameObject.transform.localScale.y;
		float local_x = gameObject.transform.localScale.x;
		int pixel_size_y = Mathf.RoundToInt((local_y * 32 * 3));
		int pixel_size_x = Mathf.RoundToInt((local_x * 32 * 3));
		float offset = local_x/2;
		for (int i = 0; i < (int)pixel_size_x/32; i++) {
			childSpriteRender = new GameObject();
			childSpriteRender.transform.parent = gameObject.transform;
			childSpriteRender.transform.localPosition = new Vector2(
				(float)childSpriteRender.transform.localScale.x*((float)i/(float)3.2f - offset + 1.0f/6.0f),
				0);
			childSpriteRender.AddComponent<SpriteRenderer> ();
			childSpriteRender.GetComponent<SpriteRenderer> ().sprite = renderPic;

		}
		Debug.Log ("DEBUG: INFO: " + pixel_size_x);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
