using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {
	
	public float jumpSpeed = 240f;
	public float forwardSpeed = 20;
	private Animator animator;

	private Rigidbody2D body2d;
	private PlayerController inputState;
	
	void Awake(){
		animator = GetComponent<Animator> ();
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<PlayerController> ();

	}
	
	// Update is called once per frame
	void Update () {
		var jumping = false;
		if (inputState.standing) {
			if(inputState.actionButton){
				body2d.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
				jumping = true;
				animator.SetBool ("Jump", jumping);
			}
		}
		
	}
}
