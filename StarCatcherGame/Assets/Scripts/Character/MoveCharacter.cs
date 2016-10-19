using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

	public CharacterController myCC;

	private Vector3 tempPos;

	public float speed = 1; 
	public float gravity = 1;
	public float jumpSpeed = 1;
	public int jumpCount = 0;
	public int jumpCountMax = 1;

	public int slideDuration = 20;
	public float slideTime = 0.01f;

	private float _h; 

//public void MoveHorizontal () {
//	myAnimation.myAnimator.SetFloat("speed", Mathf.Abs (Input.GetAxis("Horizontal")));
//}

	IEnumerator Slide ()  
	{
		int durationTemp = slideDuration;
		//while loop runs while the slideDuration is greater than 0
		float speedTemp = speed;
		//set a temp vaar to the callue of slideDuration

		while (slideDuration > 0){

			//decrease slideDuration
			slideDuration--;
			//yield "holds the coroutine"
			//return "sends" to the coroutine to do an operation while yielding
			//new creates an instance of an object
			//waitforseconds is an object that waits for seconds
			yield return new WaitForSeconds (slideTime);
			print ("sliding");


		}
		speed = speedTemp;
		slideDuration = durationTemp;
	}
	void Start () {
		myCC = GetComponent<CharacterController> ();
	}
	void Update () {


		tempPos.y -= gravity;

		tempPos.x = speed * Input.GetAxis ("Horizontal");

		myCC.Move (tempPos * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Space)) {
			
			if (myCC.isGrounded) {
				jumpCount = 0;
				tempPos.y = jumpSpeed;
				jumpCount++;
			}
			if (!myCC.isGrounded && jumpCount < 	jumpCountMax) {
				 
				jumpCount++;

				tempPos.y = jumpSpeed;
			}

			if (Input.GetKeyDown (KeyCode.RightArrow) && Input.GetKeyDown (KeyCode.S)) {
				StartCoroutine (Slide ());

			}
			if (Input.GetKeyDown (KeyCode.DownArrow) && Input.GetKeyDown (KeyCode.S)) {
				StartCoroutine (Slide ());

			}
		}
	}
}
