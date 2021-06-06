using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIpad : MonoBehaviour {
	[SerializeField] private GameObject checkLeft;
	[SerializeField] private Vector3 changePosition;
	// Use this for initialization
	void Start () {
		if (checkLeft.transform.position.x <= -3.2816f) {
			this.transform.position = changePosition;
		}
	}
}
