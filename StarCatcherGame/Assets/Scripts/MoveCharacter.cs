using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

	public float speed = 1; 
	public float gravity = 1;
	public float jumpSpeed = 1;
	public int jumpCount = 0;
	public int jumpCountMax = 2;

	public int slideDuration = 20;
	public float slideTime = 0.01f;

	IEnumerator Slide ()  
	{
		float speedTemp = speed;
		//set a temp vaar to the callue of slideDuration
		int durationTemp = slideDuration;
		//while loop runs while the slideDuration is greater than 0
		while (slideDuration > 0){

			//decrease slideDuration
			slideDuration--;
			//yield "holds the coroutine"
			//return "sends" to the coroutine to do an operation while yielding
			//new creates an instance of an object
			//waitforseconds is an object that waits for seconds
			yield return new WaitForSeconds (slideTime);

		}
		slideDuration = durationTemp;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && jumpCount < jumpCountMax - 1) {

			jumpCount++;
			temPos.y = jumpSpeed;
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S)){
			StartCoroutine ()

		}
	}
}
