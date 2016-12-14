	using UnityEngine;
	using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
	using System.Collections;
	using UnityEngine.SceneManagement; // neded in order to load scenes

	public class MenuScript : MonoBehaviour 
	{
	public AudioSource buttonClick;

	IEnumerator delay () {
		buttonClick.Play ();
		yield return new WaitForSeconds (.2f);
	}
		public Canvas quitMenu;
		public Button startText;
		public Button exitText;

		void Start ()

		{

			quitMenu = quitMenu.GetComponent<Canvas>();
			startText = startText.GetComponent<Button> ();
			exitText = exitText.GetComponent<Button> ();
			quitMenu.enabled = false;

		}

		public void ExitPress() 

		{
		StartCoroutine (delay());
			quitMenu.enabled = true; 
			startText.enabled = false; 
			exitText.enabled = false;

		}

		public void NoPress() 

		{
		StartCoroutine (delay());
			quitMenu.enabled = false; 
			startText.enabled = true; 
			exitText.enabled = true;

		}

		public void StartLevel () 
		{
		StartCoroutine (delay());
			SceneManager.LoadScene (1); 

		}

		public void ExitGame () 

		{
		StartCoroutine (delay());
			Application.Quit(); 

		}

	}
