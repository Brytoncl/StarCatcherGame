using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UvuLogo : MonoBehaviour {

	public int TimeUpFont = 10;
	public Canvas logo; 

	public IEnumerator FadeOutLogo(){
		yield return new WaitForSeconds (TimeUpFont);
		logo.enabled = false;
	}
	// Use this for initialization
	void Start () {
		StartCoroutine (FadeOutLogo ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
