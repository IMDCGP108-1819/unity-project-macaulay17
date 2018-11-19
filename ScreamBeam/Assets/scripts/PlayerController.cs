using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Use this for initialization
void Start();
public float Horizontalmovement;
public Rigidbody2D rb;  

		public class Playercontroller : MonoBehaviour {
	
	void FixedUpdate () {
		float horizontal = Input.GetAxis("horizontal") * horizontalmovement;
		rb.velocity = new Vector2("horizontal*velocity) * horizontalmovement;
	}
}
