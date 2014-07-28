using UnityEngine;
using System.Collections;

public class TransformControl : MonoBehaviour {

	public float speed= 5f;
	public Vector3 LrotateY = new Vector3(0f,45f,0f);
	public Vector3 RrotateY = new Vector3(0f,-45f,0f);

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			GetComponent<Transform>().position +=(Vector3.forward*Time.deltaTime*speed);
		}

		if(Input.GetKeyDown (KeyCode.LeftArrow))
		{
		
			GetComponent<Transform>().Rotate(LrotateY *Time.deltaTime );
		}

		//if hits right arrow then rotate -45 on Y axis
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			GetComponent<Transform>().Rotate(RrotateY *Time.deltaTime );
		}


	
	}
}
