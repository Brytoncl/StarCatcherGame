using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

	public Transform characterArt;

	public bool forward = true;

	void FlipCharacter (KeyCode _keyCode) 
	{

		switch (_keyCode) {
		case KeyCode.LeftArrow:
			print ("left");
			if (forward) {
				characterArt.Rotate (0, 180, 0);
				forward = false;
			}
			break;
		case KeyCode.RightArrow:
			print ("right");
			if (!forward) {
				characterArt.Rotate (0, 180, 0);
				forward = true;
			}
				break;
			}
		}

	void Start ()
	{
		UserInputs.UserInput += FlipCharacter;
	}
}
