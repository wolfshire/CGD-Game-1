using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour {

	[SerializeField]
	private GameObject gameOverScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGameOver(){
		gameOverScreen.SetActive (true);
	}
}
