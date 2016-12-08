using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ReplayMenuScript : MonoBehaviour {



	public void Replay () 
	{
		SceneManager.LoadScene (1); 
		Time.timeScale = 1;
		Statics.starCount = 0;

	}

	public void MainMenu () {
		SceneManager.LoadScene (0); 
		Time.timeScale = 1;
		Statics.starCount = 0;}

	public void Quit () 

	{
		Application.Quit(); 


	}
}
