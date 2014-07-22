using UnityEngine;
using System.Collections;

public class cameraCode : MonoBehaviour {
	
	//make variables
	public int turnCount = 0;
	public int camPos = 0;
	public bool phase3 = false;
	
	// Use this for initialization
	void Start () {
		
		//acessing the position of a thing
		//Debug.Log (GetComponent<Transform>().position);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (camPos == 0)
		{
			//transform.Translate(Vector3.right * Time.deltaTime);
			transform.Translate(Vector3.left * Time.deltaTime *1.6f);
			transform.Translate(Vector3.forward * Time.deltaTime *1.2f);
			transform.Translate(Vector3.down * Time.deltaTime *.4f);


		}

		Debug.Log ( "X:"  );
		Debug.Log ( GetComponent<Transform>().position.x  );
		Debug.Log ( "Y:"  );
		Debug.Log ( GetComponent<Transform>().position.y  );

		
		if(GetComponent<Transform>().position.x <-43.0f  )
		{
			if(camPos==0)
			{
				camPos++;
			}

		}
			
		if(camPos == 1)
		{
			transform.Translate(Vector3.right * Time.deltaTime *1.6f);
			//transform.Translate(Vector3.forward * Time.deltaTime *.5f);
			transform.Translate(Vector3.up * Time.deltaTime *.8f);

			if(GetComponent<Transform>().position.x <-48.0f  )
			{
				if(camPos==1)
				{
					camPos++;
				}
				
			}

		}
			
		
		
		
	}
}

