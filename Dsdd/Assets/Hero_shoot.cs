using UnityEngine;
using System.Collections;

public class Hero_shoot : MonoBehaviour {
	public GameObject indicater;
	public float indicaterDist = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		handleIndicater ();
	}

	void handleIndicater(){
		indicater.transform.position = indicaterPos ();
//		print (indicaterAngel ());
//		var target = Quaternion.Euler(0,0,indicaterAngel ());
//		//indicater.transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime);
//		print (indicater.transform.rotation);
	}
	Vector2 mousePosition(){
		Vector2 ret = new Vector2();
		Vector3 mouPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		ret.x = mouPos.x;
		ret.y = mouPos.y;
		return ret;
	}


	Vector2 indicaterPos(){
		Vector2 myPos = this.transform.position;
		Vector2 mousePos = mousePosition ();
		Vector2 v = mousePos - myPos;
		return myPos + v * indicaterDist / Mathf.Sqrt (v.x*v.x + v.y*v.y);
	}

//	float shootAngel(){
//		Vector2 myPos = this.transform.position;
//		Vector2 mousePos = mousePosition ();
//		Vector2 v = mousePos - myPos;
//		return Mathf.Atan2(v.y , v.x) / Mathf.PI * 180;
//	}
}
