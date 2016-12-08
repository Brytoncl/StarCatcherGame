using UnityEngine;
using System.Collections;

public class RecycleWolf : MonoBehaviour
{

	public WolfSpawn spawnScript;
	public GameObject wolfRef;
	public EnemyMove wolfScript;



	void OnTriggerEnter()
	{
		wolfScript.WolfRunning = false;
		wolfRef.SetActive(false);
		spawnScript.wolfReady = true;

	}
}
