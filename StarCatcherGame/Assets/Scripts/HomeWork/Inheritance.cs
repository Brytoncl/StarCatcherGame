using UnityEngine;
using System.Collections;

public class Inheritance : MonoBehaviour {

	void Start ()
	{
		print ("function");
	}

}
public class Parent {
	// needs to be public for the child script to see the function.
 public void Function(){
		//print ("function");
		// print is not accessable unless we inherite from monobehaviour.
	}
}
// this would usually be on a seperate script.
public class Child : Parent {
	// the Child script is inheriting any functions in the parent class.
	void Start () {
		Function ();
	}

}
