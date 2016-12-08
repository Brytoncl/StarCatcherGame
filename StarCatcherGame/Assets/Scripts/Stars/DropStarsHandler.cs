using UnityEngine;
using System.Collections;

public class DropStarsHandler : MonoBehaviour {

	public Transform star;
	public Rigidbody rb;
	public int ForceAmount = 100;
	// Use this for initialization
	void Start () {
		this.gameObject.SetActive (false);
		Crash.DropStars += ThrowStar;
		}

	public void ThrowStar(Transform bunny){
		this.gameObject.SetActive (true);
		star = bunny;
		//rb.AddForce * ForceAmount;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
