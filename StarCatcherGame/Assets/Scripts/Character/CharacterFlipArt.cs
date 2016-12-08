using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

	public Transform characterArt;
	public Transform glow;

	public bool forward = true;

	void FlipCharacter (KeyCode _keyCode) 
	{

		switch (_keyCode) {
		case KeyCode.LeftArrow:
			if (forward) {
				characterArt.Rotate (0, 180, 0);
				//glow.position = new Vector3 (characterArt.transform.position.x, characterArt.transform.position.y , -0.2f);
				forward = false;
			}
			break;
		case KeyCode.RightArrow:
			if (!forward) {
				characterArt.Rotate (0, 180, 0);
				//glow.position = new Vector3 (characterArt.transform.position.x, characterArt.transform.position.y , 0.2f);
				forward = true;
			}
				break;
			}
		}

	void Start ()
	{
		UserInputs.UserInput += FlipCharacter;
	}

	void OnDestroy () {
		UserInputs.UserInput -= FlipCharacter;
	}
}
