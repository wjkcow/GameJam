using UnityEngine;
using System.Collections;

public class Hero_shoot : MonoBehaviour {
	public GameObject indicater;
	public GameObject bulletPrefab;
	public GameObject bulletProtalPrefab;
	public float indicaterDist = 0.2f;
	public float shootInterval = 1.0f;
	public float bulletSpeed = 1.0f;

	private float lastShootTime;

	private Animator anim;

	// Use this for initialization
	void Start () {
		lastShootTime = Time.time;
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		handleIndicater ();
		shoot ();
	}

	// handle the place of indicater
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

	// if mouse pressed, shoot
	void shoot(){
		anim.SetBool("isShooting", false);
		if (Input.GetMouseButtonDown (0)) {
			if (Time.time > lastShootTime + shootInterval){
				GameObject newBullet =  (GameObject)Instantiate (bulletPrefab, transform.position, Quaternion.identity);
				//newBullet.transform.position = transform.position;
				newBullet.rigidbody2D.velocity = bulletSpeed * shootAngel();
				lastShootTime = Time.time;
			}	
		}
		if (Input.GetMouseButtonDown (1)) {
			if (Time.time > lastShootTime + shootInterval){
				GameObject newBullet =  (GameObject)Instantiate (bulletProtalPrefab, transform.position, Quaternion.identity);
				//newBullet.transform.position = transform.position;
				newBullet.rigidbody2D.velocity = bulletSpeed * shootAngel();
				lastShootTime = Time.time;
			}	
		}
	}

	// angle to shoot
	Vector2 shootAngel(){
		Vector2 myPos = this.transform.position;
		Vector2 mousePos = mousePosition ();
		Vector2 v = mousePos - myPos;
		//animation
		anim.SetBool("isShooting", true);
		float angleX = (int)Vector2.Angle(Vector2.right,v);
		if(v.y>=0)
			anim.SetFloat("shootDir", angleX);
		else
			anim.SetFloat("shootDir", -angleX);
		if (angleX > 90) {
			if (Hero_BaseMovement.facingRight)
				Flip ();
		}
		if (angleX <= 90) {
			if (!Hero_BaseMovement.facingRight)
				Flip ();
		}

		return v.normalized;
	}

	void Flip(){
		Hero_BaseMovement.facingRight = !Hero_BaseMovement.facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
