using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour {
	public static CoinManager instance;
	[SerializeField] private GameObject[] coins;
	[SerializeField] private Text coin;
	private int coinsPoint;
	private bool eggEatCoin = false;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		coinsPoint = PlayerPrefs.GetInt ("coinPoint", coinsPoint);
		coin.text = "" + coinsPoint;
		StartCoroutine (Coin (Random.Range(0,9)));
	}

	IEnumerator Coin (int coinIndex) {
		coins [coinIndex].SetActive (true);
		yield return new WaitForSeconds (3f);
		if (eggEatCoin == true) {
			coinIndex = Random.Range(0,9);
			eggEatCoin = false;
		}
		StartCoroutine (Coin (coinIndex));
	}

	public void EatCoin () {
		coinsPoint = coinsPoint + 1;
		coin.text = "" + coinsPoint;
		PlayerPrefs.SetInt ("coinPoint", coinsPoint);
		eggEatCoin = true;
	}



}
