using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

	public float remainingTime = 300;

	public Text timer;

	public float secondsToMin = 60;
	public int seconds;
	public int minutes;

	public Canvas ReplayMenu;
	public Text Score;




	void Start () {
		seconds = (int)(remainingTime % secondsToMin); 
		minutes = (int)(remainingTime / secondsToMin);
		timer.text = minutes + ":" + seconds;
		ReplayMenu = ReplayMenu.GetComponent<Canvas> ();
		Score = Score.GetComponent<Text> ();
		ReplayMenu.enabled = false;

	}
	// Update is called once per frame
	void Update () {
		remainingTime -= Time.deltaTime;
		timer.text = " " + Mathf.Round(remainingTime);
		seconds = (int)(remainingTime % secondsToMin); 
		minutes = (int)(remainingTime / secondsToMin);
		timer.text = minutes + ":" + seconds;

		if (remainingTime <= 0) {
			Time.timeScale = 0;
			ReplayMenu.enabled = true;
			Score.text = "Score: " + Statics.starCount;		}
	}
}

