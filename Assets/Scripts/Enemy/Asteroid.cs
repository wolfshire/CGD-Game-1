using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Called by custom AnimationEvent
	void OnAnimationEnd() {
		Destroy (this.gameObject);
	}
}
