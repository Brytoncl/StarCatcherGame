using UnityEngine;
using System.Collections;

public class CloneStar : MonoBehaviour {
	public Transform[] spawnPoints;
	public float spawnFrequency = 1f;
	public Transform star;
	public bool canSpawnStars = true;

	private int _i = 0;

	IEnumerator SpawnStars () {
		while (canSpawnStars) {
			
			_i = Random.Range (0, spawnPoints.Length-1);
			Instantiate(star, spawnPoints[_i].position, Quaternion.identity);
			yield return new WaitForSeconds(spawnFrequency);
		}
	}
	void Start () {
		StartCoroutine(SpawnStars());
	}
}
