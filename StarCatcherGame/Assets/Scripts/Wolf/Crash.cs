using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Crash : MonoBehaviour {

	public Transform bunny;

	public Canvas ReplayMenu;
	public Text Score;

	void Start () {
		ReplayMenu = ReplayMenu.GetComponent<Canvas> ();
		Score = Score.GetComponent<Text> ();
		ReplayMenu.enabled = false;
	}



	public static Action<Transform> DropStars;

	public bool canAttack = true;

	public StarCounter myStarCounter = new StarCounter();

	public void GameOver() {
		Time.timeScale = 0;
		ReplayMenu.enabled = true;
		Score.text = "Score: " + Statics.starCount;		}

	IEnumerator Attacking () {
		yield return new WaitForSeconds (1f);
		canAttack = true;
	}
	void OnTriggerEnter (){
		if (canAttack == true) {
			Statics.starCount -= 3;
			if (Statics.starCount < 0) {
				Statics.starCount = 0;
				GameOver ();
				}
			//DropStars (bunny);
			myStarCounter.starCountText.text = "Stars: " + Statics.starCount;
			canAttack = false;
			StartCoroutine (Attacking ());
			print (canAttack);
		}
	}
}
