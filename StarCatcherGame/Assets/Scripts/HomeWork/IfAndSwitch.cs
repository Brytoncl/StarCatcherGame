using UnityEngine;
using System.Collections;

public class IfAndSwitch : MonoBehaviour {


	public int health;

	public int recover;

	public int damage;


	int randomPickup = 2;


	void DamagePlayer () {
		health -= damage;
		print (health);
		RecoverHealth ();
	}
	//this is a scenario where I would want to have an if statement because I only have a couple of options to deal with
	void RecoverHealth () {
		if (health <= 80) {
			health += recover;
			print (health);
			RecoverHealth ();

		} else
			print ("healht is good");
	}

	// will perform different actions based on the value of the random pickup
	//switch statements are good for reacting to multiple changing vaariables its not limited to two options.

	void Action () {
		switch (randomPickup) {
		case 1:
			print ("picked up a health power up");
			//assignes a random value to random pickup
			randomPickup = Random.Range (0,4);
			break;
		case 2:
			print ("picked up a speed power up");
			randomPickup = Random.Range (0,4);
			break;
		case 3:
			print ("picked up a damage power up");
			randomPickup = Random.Range (0,4);
			break;
		case 4:
			print ("picked up an over shield");
			randomPickup = Random.Range (0,4);
			break;
		default:
			print ("no active power up");
			randomPickup = Random.Range (0,4);
			//I realize there is an error with the random.range but it is doing what i want for now regardless and I would find a solution if I was intending on using this script.
			break;
	
		}
	}
	// Use this for initialization
	void Start () {
		Action ();
		print (health);
		DamagePlayer ();
		Action ();
	}
}
