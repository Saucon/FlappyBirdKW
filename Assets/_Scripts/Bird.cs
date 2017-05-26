using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	public float upForce = 200f;


	private Rigidbody2D mRigidBody2D;
	public bool isDead = false;
	public Animator anim;

	// Use this for initialization
	void Start () {
		mRigidBody2D = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (isDead == false) {
			if (Input.GetMouseButtonDown (0)) {
				mRigidBody2D.velocity = Vector2.zero;
				mRigidBody2D.AddForce (new Vector2 (0, upForce));
				anim.SetTrigger("Flap");
			}
		}
	}

	void OnCollisionEnter2D(){
		isDead = true;
		anim.SetTrigger("Die");
	}
}
