using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ReplayMenuScript : MonoBehaviour {

	public AudioSource buttonClick;

	IEnumerator delay () {
		buttonClick.Play ();
		yield return new WaitForSeconds (.2f);

	}
	public void Replay () 
	{
		StartCoroutine (delay ());
		SceneManager.LoadScene (1); 
		Time.timeScale = 1;
		Statics.starCount = 0;

	}

	public void MainMenu () {
		StartCoroutine (delay ());
		SceneManager.LoadScene (0); 
		Time.timeScale = 1;
		Statics.starCount = 0;}

	public void Quit () 

	{
		StartCoroutine (delay ());
		Application.Quit(); 


	}
}
