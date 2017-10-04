using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Animator myAnimator;
	public float speed = 10;
	private bool facingRight = true;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		myAnimator.SetFloat ("speed", Mathf.Abs (horizontal));

		transform.Translate (Time.deltaTime * (speed * horizontal), 0, 0);
		Flip (horizontal);


	}

	void Flip(float horizontal) {
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
			facingRight = !facingRight;
			SpriteRenderer flipX = GetComponent<SpriteRenderer> ();
			flipX.flipX = !facingRight;
		}
	
	}


}
