using UnityEngine;
using System.Collections;

public class Cleanup : MonoBehaviour {

    float timer = 0;
    [SerializeField]
    float delTime = .1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > delTime)
        {
            Destroy(gameObject);
        }
	}
}
