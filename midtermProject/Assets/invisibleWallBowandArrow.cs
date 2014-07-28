using UnityEngine;
using System.Collections;

public class invisibleWallBowandArrow : MonoBehaviour {

	 // WHICH DOOR? ASSIGN IN UNITY INSPECTOR
	public Transform BowandArrow;
	public Transform myKeyText;
	public bool destroyWall=true; 
	public bool pickedupArrow=false;
	
	// You will need a trigger-collider on this object
	void OnTriggerEnter ( ) {		
		
		//add the key
		//treasure.GetComponent<invisiblewall>().hasKey = true;
		
		//inform the user that they picked up the key
		myKeyText.GetComponent<MeshRenderer>().enabled = true;
		myKeyText.GetComponent<TextMesh>().text= "You've unlocked the hidden\n armory should you take the \n Bow and Arrow?(y/n)";
		
	}
	
	void OnTriggerStay()
	{
		//GetComponent<Transform>().position += Vector3.down * Time.deltaTime;
		
		if(Input.GetKeyDown(KeyCode.Y))
		{
			pickedupArrow=true;
			myKeyText.GetComponent<TextMesh>().text= "Well done!\n You've obtained the \nBow and Arrow.";
		}
		
		if(pickedupArrow)
		{
			BowandArrow.GetComponent<BowandArrow>().dead=true;
			pickedupArrow=false;
			
		}
		
		
		
	}
	
	//performs actions upon exiting trigger box
	void OnTriggerExit()
	{
		//hide the text
		myKeyText.GetComponent<MeshRenderer>().enabled = false;
		
		
	}
	
	
}