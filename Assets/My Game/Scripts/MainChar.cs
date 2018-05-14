﻿using UnityEngine;
using System.Collections;

public class MainChar : MonoBehaviour {


	public float speed = 2;
	public float jumpspeed = 50;


	// Use this for initialization
	void Start () {
			// Getting the rigidbody from the game object we are attached to
			Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

			// Number between -1 and 1 based on player pressing left or right
			float horizontal = Input.GetAxis("Horizontal");

			// Boolean (true or false) based on player pressing space bar
			bool jump =Input.GetButtonDown("Jump");

			// Find out if we are touching the ground

			// Get the collider component attached to this object
			Collider2D collider = GetComponent<Collider2D>();

			// Find out if we are collidning with the ground
			LayerMask groundLayer = LayerMask.GetMask("Ground");
			bool touchingGround = collider.IsTouchingLayers(groundLayer);

		//Debug.Log(Horizontal);
			// Cache a local copy of our rigidbody's velocity
			Vector2 velocity = rigidBody.velocity;

			// Set the x (left/right) component of the velocity based on our input
			velocity.x = horizontal * speed;
			// Set the y (up/down) component of the velocity based on jump
			if (jump == true && touchingGround == true) 
			{
				velocity.y = jumpspeed;
			}

			//Print a log when mouse button is pressed
			if (Input.GetMouseButton(0))
			{
				Debug.Log("Mouse button down");
				//Print a log of mouse position
				Vector2 mousePosition = Input.mousePosition;
				Debug.Log(" Mouse position is " + mousePosition);

			}
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
