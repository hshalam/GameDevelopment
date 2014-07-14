using UnityEngine;
using System.Collections;

public class PoemManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log ("Hello World");

		GetComponent<TextMesh>().text = "See the snow\nIts a blanket, soft and white\nFalling slow\nCovering the world, making it bright";
	} 

	// Update is called once per frame
	void Update () {
	
	}
}
