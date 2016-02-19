using UnityEngine;
using System.Collections;

public class Globals : MonoBehaviour {

	[SerializeField]
	private GameObject canvas;

	private float moonMultiplier = 1;
	public float MoonSpeedMultipler {
		get { return moonMultiplier; }
		set { moonMultiplier = value; }
	}

	private float boostTime = 0;
	[SerializeField]
	private float boostDuration = 2;
	[SerializeField]
	private float boostAmount = 4;

	private static Globals _instance;
	public static Globals Instance { get { return _instance; } }
	void Awake() { _instance = this; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (boostTime > 0) {
			boostTime -= Time.deltaTime;
			if (boostTime <= 0)
				MoonSpeedMultipler -= boostAmount;
		}
	}

	public void Boost() {
		if (boostTime <= 0) {
			MoonSpeedMultipler += boostAmount;
		}
		boostTime = boostDuration;
	}

	void OnGameOver() {
		canvas.SendMessage ("OnGameOver");
	}
}
