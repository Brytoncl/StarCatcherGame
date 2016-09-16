using UnityEngine;
using System.Collections;

public class variables : MonoBehaviour {

	public int banana = 10;
	public float apple = 5.6f;
	public string mysteryFruit;
	private float total;
	//dumb variables

	void FruitBasket () {
		print ("the banana costs " + banana);
		print ("the apple costs " + apple);
		print ("and the mystery fruit you grabbed was a(n) " + mysteryFruit);
		total = apple + banana;
		print ("your total is " + total );
	}
	//really dumb function

	// Use this for initialization
	void Start () {
		print (mysteryFruit);
		print ("banana equals "+ banana);
		banana = 15;
		apple = 7.8f;
		print ("banana equals "+ banana);
		print ("apple equals " + apple);
		FruitBasket ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
