using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public NavMeshAgent navAgent;
	public Transform myPlayer;

	void Update () {
		navAgent.destination = myPlayer.position;
	}
}
