using UnityEngine;
using System.Collections;
using System;

public class ConventionsAndSyntax : MonoBehaviour {

	//players health
	//I have to put f at the end of the assigned variable for a float
	public float health = 110.5f;

	//the damage being delt to the player;
	public int damage;



	void HurtPlayer (){
		health -=damage;
		print (health);
	}
	// will only hurt player once.
	void Start () {
		print (health);
		HurtPlayer ();
	}

	// void update wont work because it needs to be a capital U
	//right now void update(); is a completely different function than void Update();
	void update () {
		HurtPlayer ();
	}

	//this update will work
	void Update (){
	
	}
}
