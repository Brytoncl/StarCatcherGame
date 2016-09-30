using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour {

	public bool canRecycle;

	public Transform cube;

	/*IEnumerator WaitToRecycle() {
		yield return new WaitForSeconds (1f);
		canRecycle = true;
	}*/


	public static Action <SendToRecycler> SendThis;

	void Start () {
		/*if (canRecycle)
		SendThis (this);
		canRecycle = false;*/
		cube = this.GetComponent<Transform> ();
		if (canRecycle && SendThis != null) {
			SendThis (this);
		}
		
	}

	void OnTriggerEnter () {
		//StartCoroutine ("WaitToRecycle");
		canRecycle = true;
		Start ();
	}
}
