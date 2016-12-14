using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UvuLogo : MonoBehaviour {

	public int TimeUpFont = 10;
	public Canvas logo; 
	public AudioSource Crickets;

	public IEnumerator FadeOutLogo(){
		yield return new WaitForSeconds (TimeUpFont);
		logo.enabled = false;
	}
	IEnumerator StartMusic () {
		yield return new WaitForSeconds (TimeUpFont);
		Crickets.Play ();
	}
	// Use this for initialization
	public void Start () {
		StartCoroutine (StartMusic ());
		StartCoroutine (FadeOutLogo ());
	}
}
