using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
//	public float speed = 1.0f;
//	public bool facingRight = true;
	// Use this for initialization
	private Animator anim;
//	public bool grounded = false;
//	public Transform groundCheck;
//	public float groundRadius = 0.02f;
//	public LayerMask whatIsGround;
//	public float jumpForce;
//
//	public bool doubleJump = false;
//
//	public float maxJumpPressInterval = 0.3f;
//	public float secondJumpDecay = 0.82f;

    Camera camera;
	void Start () {
		anim = GetComponent<Animator> ();
        // camera = GameObject.Find("Camera").camera;
//        if (!networkView.isMine)
//        {
//            enabled = false;
//        }
	}
	
	// FixedUpdate is called once per frame
//	
//	void FixedUpdate () {
//		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
//		if (grounded){
//			doubleJump = false;
//
//		}
//		anim.SetBool ("Ground", grounded);
//		float move = Input.GetAxisRaw ("Horizontal");
//		anim.SetFloat ("vSpeed", rigidbody2D.velocity.y);
//		anim.SetFloat ("Speed", Mathf.Abs(move));
//
//		rigidbody2D.velocity = new Vector2(move*speed, rigidbody2D.velocity.y);
//		if(move > 0 && !facingRight)
//			Filp();
//		else if (move < 0 && facingRight)
//			Filp();
//	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow)
		   || Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.D))
		{
			anim.SetBool("isWalking", true);
		}		
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			anim.SetBool("onGround", false);
		}		
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{		
			anim.SetBool("isDun", true);
		}

		if(Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.RightArrow))
		{
			anim.SetBool("isWalking", false);
		}		
		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			anim.SetBool("onGround", true);
		}		
		if(Input.GetKeyUp(KeyCode.DownArrow))
		{		
			anim.SetBool("isDun", false);
		}
	}

//	void Filp(){
//		facingRight = !facingRight;
//		Vector3 theScale = transform.localScale;
//		theScale.x *= -1;
//		transform.localScale = theScale;
//	}
}
