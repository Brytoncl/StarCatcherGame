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


	void Start () {
		seconds = (int)(remainingTime % secondsToMin); 
		minutes = (int)(remainingTime / secondsToMin);
		timer.text = minutes + ":" + seconds;

	}
	// Update is called once per frame
	void Update () {
		remainingTime -= Time.deltaTime;
		timer.text = " " + Mathf.Round(remainingTime);
		seconds = (int)(remainingTime % secondsToMin); 
		minutes = (int)(remainingTime / secondsToMin);
		timer.text = minutes + ":" + seconds;

		if (remainingTime <= 0) {
			SceneManager.LoadScene (0);
		}
	}
}
