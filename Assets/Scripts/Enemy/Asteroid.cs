using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	private bool returned = false; // Sent back to moon
	[SerializeField]
	private Collider _collider;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(!returned && Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hitInfo;
			Physics.Raycast (ray, out hitInfo);

			if (hitInfo.collider == _collider) {
				returned = true;
				anim.SetFloat ("speed", -1);
			}
		}
	}

	void OnMouseDown() {
		Debug.Log ("Hit?");
	}

	// Called by custom AnimationEvent
	void OnAnimationBegin() {
		if (returned) {
			GameObject.Find ("Moon").SendMessage ("AsteroidBump");
			Destroy (this.gameObject);
		}
	}
	// Called by custom AnimationEvent
	void OnAnimationEnd() {
		if (!returned) {
			Globals.Instance.Boost ();
			GameObject.Find ("Player").SendMessage ("Swerve");
			Destroy (this.gameObject);
		}
	}
}
