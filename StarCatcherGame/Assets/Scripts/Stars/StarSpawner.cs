using UnityEngine;
using System.Collections;
using System;

public class StarSpawner : MonoBehaviour {

	public static Action <StarSpawner> SendThis;

	void Start () {
		if (SendThis != null) {
			SendThis (this);
			}
		this.gameObject.SetActive (false);
	}
}