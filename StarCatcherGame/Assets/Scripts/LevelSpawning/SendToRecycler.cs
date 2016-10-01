using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour {

	public bool canRecycle;

	public Transform cube;


	public static Action <SendToRecycler> SendThis;

	void Start () {
		cube = this.GetComponent<Transform> ();
		if (canRecycle && SendThis != null) {
			SendThis (this);
		}
		
	}

	void OnTriggerEnter () {
		canRecycle = true;
		Start ();
	}
}
