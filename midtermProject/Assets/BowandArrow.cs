using UnityEngine;
using System.Collections;

public class BowandArrow : MonoBehaviour {
	public bool dead= false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(dead)
		{
			Destroy(gameObject);
		}
	}
}
	
