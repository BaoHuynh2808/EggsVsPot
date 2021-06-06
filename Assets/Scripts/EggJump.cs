using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggJump : MonoBehaviour {
	public static EggJump instance;

	[SerializeField] private float jumpForce;
	[SerializeField] private float rayLength;
	[SerializeField] private LayerMask layer;
	[SerializeField] private float checkpointYPosition;

	private RaycastHit2D hit;
	private Rigidbody2D eggBody;
	private bool isTouch = false;
	private Collider2D colider;
	private int isTouchPoint = 0;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
		SetCameraY ();
	}

	// Use this for initialization
	void Start () {
		eggBody = this.GetComponent<Rigidbody2D> ();
		colider = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameManager.instance.GameOver) {
			if (Input.GetMouseButtonDown (0)) {
				GameManager.instance.PlayGame ();
				RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down, rayLength, layer.value);
				if (hit.collider != null) {
					GameManager.instance.EggJumping ();
					isTouch = false;
					eggBody.velocity = new Vector2 (0, 0);
					eggBody.AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
				}
			} else {
				GameManager.instance.EggFalling ();
			}
			if (GameManager.instance.EggFall) {
				if (transform.position.y < checkpointYPosition && isTouch == true) {
					colider.isTrigger = true;
					GameManager.instance.EggDied ();
				}
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Cup" && isTouch == true && GameManager.instance.GameOver == false) {
			GameManager.instance.CaclulatePoint ();
		}
		if (other.gameObject.tag == "checkpoint") {
			checkpointYPosition = other.gameObject.transform.position.y;
		}
		if (other.gameObject.tag == "checktouch") {
			isTouch = true;
		}
		if (other.gameObject.tag == "Coin" && GameManager.instance.GameOver == false) {
			CoinManager.instance.EatCoin ();
			other.gameObject.SetActive (false);
		}
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (!GameManager.instance.GameOver) {
			if (other.gameObject.tag == "Ground") {
				GameManager.instance.EggDied ();
			}
			if (GameManager.instance.PlayerPlayGame) {
				if (other.gameObject.tag == "BigCup") {
					GameManager.instance.EggDied ();
				}
			}
		}
	}

	void SetCameraY() {
		MoveCamera.offsetY = Camera.main.transform.position.y - transform.position.y - 0.5f;
	}

	public float GetPositionY () {
		return transform.position.y;
	}


}
