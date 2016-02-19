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

	private static Globals _instance;
	public static Globals Instance { get { return _instance; } }
	void Awake() { _instance = this; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGameOver() {
		canvas.SendMessage ("OnGameOver");
	}
}
