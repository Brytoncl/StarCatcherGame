using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour {

	public bool canRecycle;

	public Transform cube;


	public static Action <SendToRecycler> SendThis;

	void Start () {
		/*if (canRecycle)
		SendThis (this);
		canRecycle = false;*/
		cube = this.GetComponent<Transform> ();
		if (SendThis != null && canRecycle) {
			SendThis (this);
		}
		
	}

	void OnTriggerEnter () {
		canRecycle = true;
		Start ();
	}
}
