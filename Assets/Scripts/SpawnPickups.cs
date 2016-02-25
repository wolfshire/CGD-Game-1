using UnityEngine;
using System.Collections;

public class SpawnPickups : MonoBehaviour {

    float timer = 0;
    int random;
    public GameObject pickup;
    float spawnX;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            random = Random.Range(0, 2);
            if (random == 0)
            {
                spawnX = -3f;
            }
            else if (random == 1)
            {
                spawnX = 3f;
            }
            random = Random.Range(0, 2);
            if (random == 0)
            {
                Instantiate(pickup, new Vector3(spawnX, transform.position.y, transform.position.z), transform.rotation);
            }
            timer = 0;
        }
	}
}
