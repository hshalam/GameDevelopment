using UnityEngine;
using System.Collections;

public class TextAdventure : MonoBehaviour {

	string currentRoom= "Castle";
	bool hasBowandArrow=false;
	bool hasKey=false;

	// Update is called once per frame
	void Update () {
		string textBuffer = "You are currently in: "+ currentRoom;
		if ( currentRoom == "Castle" ) {

			textBuffer += "\nYou see several stern knights \nstanding as guards.";

			textBuffer +="\nPress [W] to go to the armory";
			textBuffer += "\npress [S] to go the dungeon";

			if (Input.GetKeyDown (KeyCode.W)  ) {
				currentRoom= "Armory";
			}else if (Input.GetKeyDown (KeyCode.S) ) {
				currentRoom ="Dungeon";
			}
		}else if (currentRoom == "drawbridge") {
			textBuffer += "\nBe careful not to wake up the agressive Aligators \nthat live wihin the mote\nYou stumble upon a pair of keys\n lying on the floor";
			textBuffer +="\nPress [W] to go inside the Dungeon";
	
			hasKey= true;

			if (Input.GetKeyDown (KeyCode.W)  ) {
				currentRoom= "Dungeon";
			}

		}else if ( currentRoom == "Dungeon") {

			textBuffer += "\nIT IS REALLY DARK! \nYou grab a torch from the wall for lighting\n You see a stairway to the Tower\nand a narrow pathway leading to the Drawbridge.";
			textBuffer += "\npress [S] To go back inside the Castle.";
			textBuffer += "\nPress [W] to climb up to the Tower";
			textBuffer += "\nPress [A] to go to the Drawbridge";


			if (Input.GetKeyDown (KeyCode.S)){
				currentRoom= "Castle";
		}
			if (Input.GetKeyDown (KeyCode.A)){
				currentRoom= "drawbridge";
			}
		if (Input.GetKeyDown (KeyCode.W)){
			currentRoom= "Tower";
			}
	}

		else if ( currentRoom == "Tower" ) {
			


		if (hasKey==false) {
			textBuffer += "\nYou can't go in without your key though...\n Press [W] to go back to the Dungeon";
			
		} else {

			textBuffer += "\nYou use your key to unlock the door to the tower.";
			textBuffer += "\nYou see a Princess locked up in a cage \nguarded by a fire breathing dragon!";
			
				if (hasBowandArrow==false) {
					textBuffer += "\nYou have no weapon!\n press [W] to go back to the dungeon \n to avoid the dragon.";

				}
				else {
					textBuffer += "\nYou slay the dragon with your bow and arrow\nand save the Princess!\npress [W] to go back to the dungeon.";
				}

		}
		if (Input.GetKeyDown (KeyCode.W)  ) {
			currentRoom= "Dungeon";
		} 
	}else if ( currentRoom == "Armory" ) {
				
				textBuffer += "\nYou see a steal bow and arrow and pick it up";
				
				textBuffer +="\nPress [W] to go back to the castle";
				
			hasBowandArrow=true;

				
				if (Input.GetKeyDown (KeyCode.W)  ) {
					currentRoom= "Castle";
			}
	}



		GetComponent<TextMesh>().text=textBuffer;

		


	


	
	}
}
