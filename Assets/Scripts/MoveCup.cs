using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCup : MonoBehaviour {
	[SerializeField] private float speed;
	[SerializeField] private Vector3 rightPosition;
	[SerializeField] private Vector3 leftPosition;

	// Use this for initialization
	void Start () {
		leftPosition.x = GetPosition.instance.PositionXLeft;
		rightPosition.x = GetPosition.instance.PositionXRight;
		StartCoroutine (Move (rightPosition));
	}

	IEnumerator Move (Vector3 target) {
		while (Mathf.Abs ((target - transform.localPosition).x) > 0.2f) {
			if (!GameManager.instance.GameOver) {
				Vector3 direction = target.x == rightPosition.x ? Vector3.right : Vector3.left;
				transform.localPosition += direction * Time.deltaTime * speed;
			}
			yield return null;
		}
		yield return new WaitForSeconds (0f);//when reached target wait
		Vector3 newTarget = target.x == rightPosition.x ? leftPosition : rightPosition;
		StartCoroutine (Move (newTarget));
	}
}
