using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {

	private ArraysandLists myArrays;

	private ScopeAndAccessModifiers myScope; 
	void Start () {
		myScope = new ScopeAndAccessModifiers ();
		myArrays = new ArraysandLists ();
		PopulateEnemies ();
		// this gives me access to the variables and functions in those scripts if I reference them first.
	}
	void PopulateEnemies () {
		while (myScope.enemyCount < 5) {
			myScope.enemyCount += 1;
		}
	}
}
// while loop 
//while (int > = or <) {
//
//}
//
// for loop 
//For (int i = 0, i < enemisList.Count , i++){
//
//}
//
// for each loop 
//foreach (string item in strings){
