
using UnityEngine;
using System.Collections;

public class CloneStar : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] stars;
	public float spawnFrequency = 7;
	public float DeactivateTime = 6;
	public bool canSpawnStars = true;


	private int i = 0;
	private int j = 0;

	IEnumerator DeactivateStars () {
		yield return new WaitForSeconds (DeactivateTime);
		stars [j].SetActive (false);
	}

	IEnumerator SpawnStars ()
	{
		while (canSpawnStars)
		{
			i = Random.Range(0, spawnPoints.Length - 1);
			stars[j].transform.position = spawnPoints[i].position;
			stars[j].SetActive(true);
			StartCoroutine (DeactivateStars ());

			yield return new WaitForSeconds(spawnFrequency);

			if (j < stars.Length-1)
			{
				j++;
			} else
			{
				j = 0;
			}
			//Instantiate(star, spawnPoints[i].position, Quaternion.identity);

		}
	}
	void Start () {
		StartCoroutine(SpawnStars());

	}

}