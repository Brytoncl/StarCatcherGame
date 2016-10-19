using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

	public Animator myAnimator;
	private float _h; 

	void Start () {
		myAnimator = GetComponent<Animator> ();
		_h = Input.GetAxis( "Horizontal");
	}

	void Update () {
		myAnimator.SetFloat ("speed", _h);
	}
}
