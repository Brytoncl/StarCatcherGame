using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	void Start () {
		Statics.nextPosition = Statics.startPosition;
	}

	void OnTriggerEnter ()
	{
		RestartLevel ();
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene (0);
	}
}
