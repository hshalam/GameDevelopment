using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

	public float rotateSpeed=45.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		CharacterController controller = GetComponent<CharacterController>();

		if(Input.GetKeyDown (KeyCode.UpArrow))
		{

		controller.Move(Vector3.forward);
		}
		//add Horizontal input axis 
		GetComponent<Transform>().Rotate (0, Input.GetAxis ("Horizontal") * rotateSpeed, 0) ;

		//if player taps space bar and they are on the ground then simple move upwards
		if(Input.GetKeyDown(KeyCode.Space) )
		{
			Debug.Log ("working");
			//controller.SimpleMove(Vector3.up* 1000);
		}
	}
}
