using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterGameManager : MonoBehaviour {
	public static EnterGameManager instance = null;
	private int bestScore;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}

	void Start() {
		bestScore = PlayerPrefs.GetInt ("bestscore", bestScore);
	}

	public void LoadGamePlay () {
		SceneManager.LoadScene (2);
	}

	public void GotoShop () {
		SceneManager.LoadScene (3);
	}
}
