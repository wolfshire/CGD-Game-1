using UnityEngine;
using System.Collections;

public class ForwardOnClick : MonoBehaviour {

	[SerializeField]
	private GameObject target;
	void OnMouseDown(){
		target.SendMessage ("OnMouseDown");
	}
}
