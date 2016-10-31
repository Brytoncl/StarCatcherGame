using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StarCounter : MonoBehaviour {

	public int starCount = 0;
	public Text starCountText;

	public void AddStar() {
		starCountText.text = "Stars: " + starCount;
	}
		
}
