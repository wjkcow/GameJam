using UnityEngine;
using System.Collections;

public class Hero_BaseMovement : MonoBehaviour {
	bool isJumping = false;
	bool jumpTurnLeft = false;
	bool jumpTurnRight = false;
	public Vector2 walkRightSpeed = new Vector2(2.0f,0.0f);
	public Vector2 jumpRightSpeed = new Vector2(0.5f,0.0f);
	public Vector2 jumpSpeed = new Vector2(0.0f, 10.0f);
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		jump ();
		move ();
	}

	// jump when space is press down, left/right jump if Arrow pressed
	// if in the air change direction if arrow pressed
	void jump(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Vector2 speed = jumpSpeed;
			if(Input.GetKey (KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
				speed += -1 * jumpRightSpeed;
			} else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D) ){
				speed += jumpRightSpeed;
			}
			if(!isJumping){
				this.rigidbody2D.velocity = speed;
				isJumping = true;

			}
		}
		if(isJumping){
			Vector2 speed = Vector2.zero;
			if(Input.GetKey (KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ){
				if(!jumpTurnLeft){
					this.rigidbody2D.velocity = new Vector2(0.0f, this.rigidbody2D.velocity.y);
					speed += -1 * jumpRightSpeed;
					jumpTurnLeft = true;
				}
			} else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)){
				if(!jumpTurnRight){
					this.rigidbody2D.velocity = new Vector2(0.0f, this.rigidbody2D.velocity.y);
					speed += jumpRightSpeed;
					jumpTurnRight = true;
				}
			}
			this.rigidbody2D.velocity += speed;
		} 
	}

	// if not jumping move left or right
	void move(){
		if (!isJumping) {
			if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
				this.transform.Translate(-1 * walkRightSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
				this.transform.Translate(walkRightSpeed * Time.deltaTime);
			}
		}
	}

	void postJump(){
		isJumping = false;
		jumpTurnLeft = false;
		jumpTurnRight = false;
	}
	void OnTriggerEnter2D(Collider2D other){
		postJump ();
	} 
}
