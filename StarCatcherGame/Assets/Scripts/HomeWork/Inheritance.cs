using UnityEngine;
using System.Collections;

public class Inheritance : MonoBehaviour {


}
public class Parent : MonoBehaviour {

	public void Function (){
		print ("function");
	}
}

public class Child : Parent {

	void Start () {
		Function ();
	}

}
