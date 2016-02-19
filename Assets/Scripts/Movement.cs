using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	[SerializeField]
	private Vector2 hardLimit;
	[SerializeField]
	private Vector2 slowdownLimit;
	[SerializeField]
	private float moonSpeedIncrease = 4f;
	[SerializeField]
	private float speed;
	[SerializeField]
	private float perlinMultiplier = 10;
	[SerializeField]
	private float perlinSpeedChangeAmount = 5;

	private GameObject car;
	private bool slowingMoon = false;

	// Use this for initialization
	void Start () {
		car = this.transform.FindChild ("Car").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		float dir = Input.GetAxis ("Horizontal");
		float random = Mathf.PerlinNoise (1234, Time.timeSinceLevelLoad * perlinMultiplier)*2-1;
		float delta = dir + speed * random * perlinSpeedChangeAmount * Time.deltaTime;

		Vector3 pos = car.transform.localPosition;
		pos.x += delta;
		pos.x = Mathf.Clamp (pos.x, hardLimit.x, hardLimit.y);

		if (pos.x < slowdownLimit.x || pos.x > slowdownLimit.y) {
			if (!slowingMoon) {
				slowingMoon = true;
				Globals.Instance.MoonSpeedMultipler += moonSpeedIncrease;
				pos.y = 0.4f;
				Debug.Log ("SLOW");
			}
		} else if (slowingMoon) {
			slowingMoon = false;
			Globals.Instance.MoonSpeedMultipler -= moonSpeedIncrease;
			pos.y = 0;
			Debug.Log ("NO SLOW");
		}


		car.transform.localPosition = pos;
	}
}
