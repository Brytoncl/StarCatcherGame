using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StarCounter : MonoBehaviour {

	public AudioSource addStar;
	public Text starCountText;


	void OnTriggerEnter (Collider col) {

		if (col.tag == "Player") {
			gameObject.SetActive (false);
			Statics.starCount += 1;
			AddStar ();
		}
	}

	public void AddStar() {
		addStar.Play ();
		starCountText.text = "Stars: " + Statics.starCount;
	}
	void Start () {
		starCountText.text = "Stars: " + 0;
		AddStar ();
	}
}
