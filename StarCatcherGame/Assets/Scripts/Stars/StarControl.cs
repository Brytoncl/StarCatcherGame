using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarControl : MonoBehaviour {


	public bool canAddForce = true;
	public float forceDuration = .1f;
	private Rigidbody rb;
	public int forceRangeHigh = 500;
	public int forceRangeLow = 200;
	private Vector3 forceVector;
	int i;


	//private Animator StarAnimator;

	public void Start () {
		//RunRandomForce ();
		rb = GetComponent<Rigidbody> ();

	}

	void OnTriggerEnter () {
//		i = Random.Range (-forceRangeHigh, -forceRangeLow);
//		forceVector.x = i;
//		rb.AddForce (forceVector);
	}
		
//	IEnumerator RunRandomForce()
//	{
//		while (canAddForce) {
//			forceVector.x = -100;
//			rb.AddForce (forceVector);
//			yield return new WaitForSeconds (forceDuration);
//			}
//		}
	}
	
