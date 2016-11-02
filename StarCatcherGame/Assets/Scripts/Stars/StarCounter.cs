using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StarCounter : MonoBehaviour {

	public int starCount = 0;
	public Text starCountText;


	void OnTriggerEnter () {
		//StarAnimator.SetBool ("Destroy", true);
		gameObject.SetActive (false);
		starCount += 1;
		AddStar ();
	}

	public void AddStar() {
		starCountText.text = "Stars: " + starCount;
	}
	void Start () {
		AddStar ();
	}
}
