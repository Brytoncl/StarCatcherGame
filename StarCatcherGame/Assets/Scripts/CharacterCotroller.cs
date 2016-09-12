using UnityEngine;
using System.Collections;

public class CharacterCotroller : MonoBehaviour {

	//this is the character controller component
	private CharacterController myCC; 
	private Vector3 tempPos;

	public float speed;
	public float jumpHeight;
	public float gravity;

	//temp Var of datatype vector3 to moce the character.

	void Strafe () {
		
	}

	void Start () {
		//this finds the character component
		myCC = GetComponent<CharacterController> ();

	}

	void Update () {
		
			
	
		if (Input.GetKeyDown (KeyCode.Space)) {
			tempPos.y = jumpHeight;
		}

		tempPos.y -= gravity;
		tempPos.x = speed * Input.GetAxis("Horizontal");
		myCC.Move(tempPos * Time.deltaTime);

		
	}
}
