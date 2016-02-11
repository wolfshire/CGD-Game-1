using UnityEngine;
using System.Collections;

public class Globals : MonoBehaviour {

	[SerializeField]
	private GameObject canvas;

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
