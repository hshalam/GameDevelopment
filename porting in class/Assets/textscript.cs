using UnityEngine;
using System.Collections;

public class textscript : MonoBehaviour {
	int CharacterCounter = 0;
	float coinflip;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		//flip a coin
		coinflip= Random.Range(0,10);

		//check if heads or tails
		if (coinflip< 5)
		{
			GetComponent<TextMesh>(). text+="/";

		}
	     else
		{
			GetComponent<TextMesh>(). text+="\\";
		}
		//increment character count
		CharacterCounter ++;

		//chech if we should add a new line
		if (CharacterCounter>20)
		{
			GetComponent<TextMesh>().text += "\n";
		

			  //reset counter
				CharacterCounter =0;
		}
	}
		
}
