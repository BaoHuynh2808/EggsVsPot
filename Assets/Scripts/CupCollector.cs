using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupCollector : MonoBehaviour {
	[SerializeField] GameObject[] cups;
	private float lastCup;
	[SerializeField] private float distance;

	void Awake() {
		lastCup = cups [0].transform.position.y;
		for (int i = 1; i < cups.Length; i++) {
			if (lastCup <  cups[i].transform.position.y) {
				lastCup = cups[i].transform.position.y;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Cup") {
			Vector3 temp = other.transform.position;
			temp.y = lastCup + distance;
			other.transform.position = temp;
			lastCup = temp.y;
		}
	}
}
