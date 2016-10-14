using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	public NavMeshAgent myAgent;
	public Transform player;

	void Start () {

	}
	void update (){
		myAgent.destination = player.position;
	}
}
