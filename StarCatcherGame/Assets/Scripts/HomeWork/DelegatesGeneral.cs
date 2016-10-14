using UnityEngine;
using System.Collections;
using System; 

public class DelegatesGeneral : MonoBehaviour {



	Action Move;
	Action Idle;
	Action Jump;


	void MoveHandler() {
		print ("Moving");
	}

	void IdleHandler() {
		print ("Idleing");

	}

	void JumpHandler() {
		print ("Jumping");
	}
	// Use this for initialization
	void Start () {
		Move += MoveHandler;


	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}
}
