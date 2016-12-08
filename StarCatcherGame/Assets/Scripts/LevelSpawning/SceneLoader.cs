using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

	public Canvas ReplayMenu;
	public Text Score;


	//public SceneLoader mySceneLoader;
	// Use this for initialization
	public void StartGame ( ){
		SceneManager.LoadScene (1);
	}

	void Start () {
		Statics.nextPosition = Statics.startPosition;
		ReplayMenu = ReplayMenu.GetComponent<Canvas> ();
		Score = Score.GetComponent<Text> ();
		ReplayMenu.enabled = false;

	}

	void OnTriggerEnter () {
		Restart ();
	}
	// Update is called once per frame
	public void Restart () {
		Time.timeScale = 0;
		ReplayMenu.enabled = true;
		Score.text = "Score: " + Statics.starCount;
	}

}
