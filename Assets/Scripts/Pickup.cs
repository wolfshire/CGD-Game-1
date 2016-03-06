using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    GameObject controller;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 5f);
        controller = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);
	}

    void OnTriggerEnter(Collider o)
    {
        if (o.tag == "Player")
        {
            Debug.Log("Hit powerup");
            controller.GetComponent<GameManager>().ScoreUp(10);
            o.SendMessage("Pickup", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}
