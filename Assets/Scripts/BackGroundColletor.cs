using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundColletor : MonoBehaviour {
	[SerializeField] GameObject[] backGrounds;
	private float lastBackGround;

	void Awake() {
		lastBackGround = backGrounds [0].transform.position.y;
		for (int i = 1; i < backGrounds.Length; i++) {
			if (lastBackGround < backGrounds [i].transform.position.y) {
				lastBackGround = backGrounds [i].transform.position.y;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "BackGround") {
			Vector3 temp = other.transform.position;
			float width = ((BoxCollider2D)other).size.y;
			temp.y = lastBackGround + width;
			other.transform.position = temp;
			lastBackGround = temp.y;
		}
	}
}
