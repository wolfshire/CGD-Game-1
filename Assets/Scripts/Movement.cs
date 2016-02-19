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

	[SerializeField]
	private float swerveDuration = 2;
	[SerializeField]
	private float swervePowerMultiplier = 4;
	[SerializeField]
	private float swerveFreqMultiplier = 4;
	private float swerveTimer = 0;

	[SerializeField]
	private GameObject car;
	private bool slowingMoon = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float dir = Input.GetAxis ("Horizontal") * speed;
		float random = (Mathf.PerlinNoise (1234, Time.timeSinceLevelLoad * perlinMultiplier * (swerveTimer > 0 ? swerveFreqMultiplier : 1))*2-1)  * perlinSpeedChangeAmount;
		if (swerveTimer > 0) {
			swerveTimer -= Time.deltaTime;
			random *= swervePowerMultiplier;
			if (swerveTimer < 0)
				swerveTimer = 0;
		}

		float delta = dir * Time.deltaTime + random * Time.deltaTime; // Sum because dir can be zero

		Vector3 pos = car.transform.localPosition;
		pos.x += delta;
		pos.x = Mathf.Clamp (pos.x, hardLimit.x, hardLimit.y);

		if (pos.x < slowdownLimit.x || pos.x > slowdownLimit.y) {
			if (!slowingMoon) {
				slowingMoon = true;
				Globals.Instance.MoonSpeedMultipler += moonSpeedIncrease;
				pos.y = 0.4f;
			}
		} else if (slowingMoon) {
			slowingMoon = false;
			Globals.Instance.MoonSpeedMultipler -= moonSpeedIncrease;
			pos.y = 0;
		}

		car.transform.localPosition = pos;
	}

	void Swerve() {
		swerveTimer = swerveDuration;
	}
}
