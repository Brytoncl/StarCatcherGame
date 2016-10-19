using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

	MoveCharacter myMoveCharacter;
	public Animator myAnimator;
	private float _h;


	void Start () {
		myMoveCharacter = new MoveCharacter ();
		myAnimator = GetComponent<Animator> ();
		myMoveCharacter.myCC = GetComponent<CharacterController> ();

	}

	void Update () {
		_h = Mathf.Abs (myMoveCharacter.myCC.velocity.x);
		myAnimator.SetFloat ("speed", _h);

}
}
