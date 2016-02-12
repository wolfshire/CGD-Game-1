using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour {

	// How close and how far the moon can be from the screen
	[SerializeField]
	private Vector2 distanceLimits;

	// How quickly the moon approaches the screen
	[SerializeField]
	private float speed;

	[SerializeField]
	private GameObject moonGraphic;


	private float moonPosition;

	// Use this for initialization
	void Start () {
		SetPosition (distanceLimits.y);
	}
	
	// Update is called once per frame
	void Update () {
		SetPosition (moonPosition - speed * Time.deltaTime);
	}

	private void SetPosition(float val){
		this.moonPosition = Mathf.Clamp (val, distanceLimits.x, distanceLimits.y);
		Vector3 loc = this.moonGraphic.transform.localPosition;
		loc.y = moonPosition;
		this.moonGraphic.transform.localPosition = loc;

		if (moonPosition <= distanceLimits.x) {
			GameObject.Find ("Globals").SendMessage ("OnGameOver");
		}
	}
}
