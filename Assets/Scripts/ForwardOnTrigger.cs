using UnityEngine;
using System.Collections;

public class ForwardOnTrigger : MonoBehaviour {

	[SerializeField]
	private GameObject target;

	void OnTriggerEnter(Collider c){
		target.SendMessage ("OnTriggerEnter", c);
	}
}
