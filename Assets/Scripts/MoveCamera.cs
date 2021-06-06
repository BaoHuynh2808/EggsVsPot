using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	public static float offsetY;
	// Update is called once per frame
	void Update () {
		if (!GameManager.instance.GameOver) {
			MoveTheCamera ();
		}
	}

	void MoveTheCamera () {
		Vector3 tmp = transform.position;
		tmp.y = EggJump.instance.GetPositionY () + offsetY;
		transform.position = tmp;
	}
}
