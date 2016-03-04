using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour {

	[SerializeField]
	private float modulus;
	[SerializeField]
	private float speed;
	[SerializeField]
	private float reduction;

	[SerializeField]
	private Vector3 axis;

	private Globals glob;

	private float pos;
	// Use this for initialization
	void Start () {
		glob = Globals.Instance;
	}

	// Update is called once per frame
	void Update () {
		float mul = glob.MoonSpeedMultipler > 1 ? reduction:1;
		pos += (Time.deltaTime * speed) * mul;
		this.transform.localPosition = (pos % modulus) * axis;
	}
}
