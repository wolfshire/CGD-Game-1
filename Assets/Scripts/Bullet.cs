using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    float timer = 0;
    [SerializeField]
    float delTime = .1f;
    GameObject controller;

	// Use this for initialization
	void Start () {
        controller = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > delTime)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider o)
    {
        if (o.tag == "Asteroid")
        {
            Debug.Log("Hit asteroid");
            controller.GetComponent<GameManager>().ScoreUp();
			o.SendMessage ("Shot", SendMessageOptions.DontRequireReceiver);
        }

    }
}
