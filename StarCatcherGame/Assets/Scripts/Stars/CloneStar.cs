
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloneStar : MonoBehaviour {

	public StarControl myStarControl;
	public Transform[] spawnPoints;
	private float spawnFrequency = 2;
	public float DeactivateTime = 6;
	public bool canSpawnStars = true;

	public List<StarSpawner> AvailableStars;

	private int i = 0;
	private int j = 0;

	public void SendThisHandler (StarSpawner Stars)
	{
		AvailableStars.Add (Stars);
	}




	IEnumerator DeactivateStars () {
		int x;

		x = j;
		yield return new WaitForSeconds (DeactivateTime);
		AvailableStars[x].gameObject.SetActive (false);
	}
	IEnumerator Delay (){
		yield return new WaitForSeconds (1f);
		StartCoroutine(SpawnStars());
	}


	IEnumerator SpawnStars ()
	{
		while (canSpawnStars)
		{
			i = Random.Range(0, spawnPoints.Length - 1);
			AvailableStars[j].transform.position = spawnPoints[i].position;
			AvailableStars[j].gameObject.SetActive(true);
			StartCoroutine (DeactivateStars ());

			yield return new WaitForSeconds(spawnFrequency);

			if (j < AvailableStars.Count-1)
			{
				j++;
			} else
			{
				j = 0;
			}

		}
	}
	void Start () {
		StarSpawner.SendThis += SendThisHandler;
		StartCoroutine("Delay");

	}

}

