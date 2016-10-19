using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

	public Animator myAnimator;

	void Start () {
		myAnimator = GetComponent<Animator> ();
	}


}
