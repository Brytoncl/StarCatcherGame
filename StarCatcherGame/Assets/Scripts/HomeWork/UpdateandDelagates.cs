using UnityEngine;
using System.Collections;
using System;

public class UpdateandDelagates : MonoBehaviour {

	public int health = 250;

	//actions are a type of delegate. delegates contain functions just as vars contain data;
	Action DisplayHealth;
	Action KillThePlayer;
	Action EndTheGame;

	// Use this for initialization
	void Start () {

		//assign function displayhealthhandler to function displayhealth
		DisplayHealth = DisplayHealthHandler;
	}

	void EndTHeGameHandler(){
		print ("you died!!! you didnt even get close!"); 
		EndTheGame = null;
	}

	void KillThePlayerHandler (){
		health--;
		print (health);
		if (health <= 0) {
			KillThePlayer = null;
			EndTheGame = EndTHeGameHandler;
		}
	}

	void DisplayHealthHandler ()
	{
		print ("health is good");
		//we unnasign all funcitons from displayhealth
		DisplayHealth = null;
		KillThePlayer = KillThePlayerHandler;
	}
	
	// Update is called once per frame
	void Update () {

		//we check if any funciton is assigned to display health 
		//if nothing is assigned displayHealth will not run
		if (DisplayHealth != null) {
			DisplayHealth ();
		}
		if (KillThePlayer != null){
			KillThePlayer ();
		}
		if (EndTheGame != null) {
			EndTheGame ();

		}
	}
}
