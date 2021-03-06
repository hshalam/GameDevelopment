﻿using UnityEngine;
using System.Collections;

public class RigidbodyController : MonoBehaviour {

	//create variable
	public float turnSpeed= 45f;
	public float moveSpeed= 10f;
	public float jumpForce= 250f;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Transform>().Rotate(0f,Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime,0f);
	
	}

	//all physics rigidbody call should be made in fixed update
	void FixedUpdate()
	{
		//add forces
		GetComponent<Rigidbody>().AddForce (transform.forward* Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime);
		//add force for sideways
		GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxis ("Horizontal")* moveSpeed* Time.deltaTime);

		//jump if spacebar is pressed
		if (Input.GetKeyUp(KeyCode.Space))
		{
			GetComponent<Rigidbody>().AddForce (Vector3.up * jumpForce);
		}

	}
}
