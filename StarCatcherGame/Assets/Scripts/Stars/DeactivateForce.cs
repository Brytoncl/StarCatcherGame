using UnityEngine;
using System.Collections;

public class DeactivateForce : StarControl {

	void OnTriggerEnter () {
		canAddForce = false;
	}
}
