using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {

	// How often to spawn in seconds
	[SerializeField]
	private Vector2 spawnFrequencyLimits;

	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private GameObject container;


	private float timeUntilSpawn;
	// Use this for initialization
	void Start () {
		timeUntilSpawn = Random.Range (spawnFrequencyLimits.x, spawnFrequencyLimits.y);
	}
	
	// Update is called once per frame
	void Update () {
		timeUntilSpawn -= Time.deltaTime;
		if (timeUntilSpawn <= 0) {
			timeUntilSpawn = Random.Range (spawnFrequencyLimits.x, spawnFrequencyLimits.y);
			GameObject inst = Instantiate (prefab);
			inst.transform.SetParent (container.transform, false);

			if (Random.Range (0f, 1f) < 0.5) { // Flip it randomly
				inst.transform.localScale = new Vector3 (-1, 1, 1);
			}
		}
	}
}
