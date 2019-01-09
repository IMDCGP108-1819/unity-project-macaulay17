using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

	public float Horizontalmovement;
    public float JumpForce;
	public Rigidbody2D rb; 

	void FixedUpdate () {
		float horizontal = Input.GetAxis("Horizontal") * Horizontalmovement;
		rb.velocity = new Vector2(horizontal, rb.velocity.y);

        if ( Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
	}
}
