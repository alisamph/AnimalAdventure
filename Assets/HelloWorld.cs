using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {
	
	string currentRoom = "Parlor";
	
	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "Welcome to Animal Adventure! You are in the " + currentRoom;
		
		if (currentRoom == "Parlor") {
			textBuffer += "\n Press [A] to go to the elevator";
			
			if (Input.GetKeyDown (KeyCode.A)) {
				currentRoom = "Elevator";
			}
		}
		else if (currentRoom == "Elevator") {
			textBuffer += "\n Press [B], [C], [D], [E], or [F] to go to another place";
			if (Input.GetKeyDown (KeyCode.B)) {
				currentRoom = "Balcony";
			}
			
			else if(Input.GetKeyDown (KeyCode.C)){
				currentRoom = "Cloud";
			}
			
			else if(Input.GetKeyDown (KeyCode.D)){
				currentRoom = "Dungeon";
			}
			
			else if(Input.GetKeyDown (KeyCode.E)){
				currentRoom = "Eggs";
			}
			else if(Input.GetKeyDown (KeyCode.F)){
				currentRoom = "Forest";
				
			}
		}
		
		if (currentRoom == "Balcony") {
			textBuffer += "\n You've got a great view of the empire state building";
			textBuffer += "\n But your from Brooklyn, so you don't care.";
		} 
		else if (currentRoom == "Cloud") {
			textBuffer += "\n You're on a cloud!";
			textBuffer += "\n You might die up here.";
		}
		else if(currentRoom == "RDungeon"){
			textBuffer += "\n You're in the dungeon.";
			textBuffer += "\n You're gonna rot here.";
		}
		else if(currentRoom == "Eggs"){
			textBuffer += "\n You're in a pit full of eggs?";
			textBuffer += "\n Hard boiled eggs??";
		}
		else if(currentRoom == "Forest"){
			textBuffer += "\n You made it back to the forest! Yay!";
		}
		
		GetComponent<TextMesh> ().text = textBuffer;
	}
}