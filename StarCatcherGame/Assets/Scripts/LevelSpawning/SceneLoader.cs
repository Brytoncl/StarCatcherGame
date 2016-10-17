using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	public void StartGame ( ){
		SceneManager.LoadScene (1);
	}

	void Start () {
		Statics.nextPosition = Statics.startPosition;
	}

	void OnTriggerEnter () {
		Restart ();
	}
	// Update is called once per frame
	void Restart () {
		SceneManager.LoadScene (0);
	}
}
