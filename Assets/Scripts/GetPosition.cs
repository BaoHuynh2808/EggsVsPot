using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPosition : MonoBehaviour {
	public static GetPosition instance;
	private float positionXLeft, positionXRight;
	[SerializeField] private GameObject maxLeft;
	[SerializeField] private GameObject maxRight;
	// Use this for initialization

	void Awake () {
		if (instance == null) {
			instance = this;
		}
		positionXLeft = maxLeft.transform.position.x;
		positionXRight = maxRight.transform.position.x;
	}

	public float PositionXLeft {
		get { return positionXLeft; }
	}

	public float PositionXRight {
		get { return positionXRight; }
	}
}
