using UnityEngine;
using System.Collections;

public class bookshelf : MonoBehaviour {

	public Transform invisiblewall; // WHICH DOOR? ASSIGN IN UNITY INSPECTOR
	public Transform book;
	public Transform myKeyText;
	public Transform bookcase;
	public bool destroyWall=true; 
	public bool pulledBook=false;
	
	// You will need a trigger-collider on this object
	void OnTriggerEnter ( ) {		
		
		//add the key
		//treasure.GetComponent<invisiblewall>().hasKey = true;
		
		//inform the user that they picked up the key
		myKeyText.GetComponent<MeshRenderer>().enabled = true;
		myKeyText.GetComponent<TextMesh>().text= "There's a loose book,\nshould we pull it?(y/n)";
		
	}
	
	void OnTriggerStay()
	{
		//GetComponent<Transform>().position += Vector3.down * Time.deltaTime;

		if(Input.GetKeyDown(KeyCode.Y))
		{
			pulledBook=true;
		}

		if(pulledBook)
		{
			book.GetComponent<Transform>().position += Vector3.left*Time.deltaTime*50;
			bookcase.GetComponent<Transform>().position+=Vector3.forward*Time.deltaTime*20;

		}
		if(destroyWall)
		{
			invisiblewall.GetComponent<BookshelfInvisibleWall>().dead=true;
			destroyWall=false;
		}


	}
	
	//performs actions upon exiting trigger box
	void OnTriggerExit()
	{
		//hide the text
	myKeyText.GetComponent<MeshRenderer>().enabled = false;
		
		// destroy key because we picked it up
		Destroy ( gameObject );
	}
	
	
}