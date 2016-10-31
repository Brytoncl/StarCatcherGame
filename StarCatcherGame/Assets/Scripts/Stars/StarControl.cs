using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {


	public int forceTime = 10;
	public float forceDuration = 0.1f;
	private Rigidbody rb;
	public float forceRange = 10;
	public float torqueRange = 2;
	private Vector3 forceVector;
	private Vector3 torqueVector;
	public StarCounter myStarcounter;

	//private Animator StarAnimator;

	void Start () {
		//StarAnimator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
		StartCoroutine ("RunRandomForce");
		myStarcounter = new StarCounter ();
	}
	IEnumerator RunRandomForce()
	{

		while (forceTime > 0) {
			yield return new  WaitForSeconds (forceDuration);
			forceVector.x = Random.Range (-forceRange,forceRange);
			torqueVector.z = Random.Range (-torqueRange, torqueRange);
			rb.AddTorque (torqueVector);
			rb.AddForce (forceVector);
			forceTime--;
		}
	}
	public float endTime = 3;

	public void Deactivate (){
		//StarAnimator.SetBool ("Destroy", false);
		gameObject.SetActive (false);
		myStarcounter.starCount += 1;
		myStarcounter.AddStar ();
	}

	void OnTriggerEnter () {
		//StarAnimator.SetBool ("Destroy", true);
		gameObject.SetActive (false);
		
		//Destroy (gameObject, endTime);

	}
}
