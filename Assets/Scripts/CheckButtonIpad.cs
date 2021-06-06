using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckButtonIpad : MonoBehaviour {
	[SerializeField] private GameObject checkLeft;
	[SerializeField] private Vector3 changePosition;
	// Use this for initialization
	void Start () {
		Debug.Log (this.transform.position);
		if (checkLeft.transform.position.x <= -3.2816f) {
			this.transform.position = changePosition;
		}
	}
}
