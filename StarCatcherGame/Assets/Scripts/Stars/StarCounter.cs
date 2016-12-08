using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StarCounter : MonoBehaviour {


	public Text starCountText;


	void OnTriggerEnter (Collider col) {

		if (col.tag == "Player") {
			gameObject.SetActive (false);
			Statics.starCount += 1;
			AddStar ();
		}
	}

	public void AddStar() {
		starCountText.text = "Stars: " + Statics.starCount;
	}
	void Start () {
		starCountText.text = "Stars: " + 0;
		AddStar ();
	}
}
