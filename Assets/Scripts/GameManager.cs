using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	[SerializeField] private AudioClip eggjump;
	[SerializeField] private AudioClip gameover;
	[SerializeField] private AudioSource gameSound;
	[SerializeField] private Text resultScoretext;
	[SerializeField] private GameObject gameOverMenu;
	[SerializeField] private Text bestScoreText;
	[SerializeField] private Text textScore;
	[SerializeField] private Sprite[] eggsSprite;
	[SerializeField] private SpriteRenderer gameObjectSprite;

	public static GameManager instance = null;
	private int gamePoint = 0;
	public int bestScore;
	private bool gameOver = false;
	private bool eggFall = false;
	private int eggColorIndex;
	private bool playAgain = false;
	private bool playerPlayGame = false;
	static int timeToPlay;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}

	void Start () {
		eggColorIndex = PlayerPrefs.GetInt ("eggName", eggColorIndex);
		gameObjectSprite.sprite = eggsSprite [eggColorIndex];
		bestScore = PlayerPrefs.GetInt ("bestscore", bestScore);
	}

	public bool GameOver {
		get { return gameOver; }
	}

	public int GamePoint {
		get { return gamePoint;}
	}

	public bool EggFall {
		get { return eggFall; }
	}

	public bool PlayerPlayGame {
		get { return playerPlayGame; }
	}

	public void CaclulatePoint () {
		gamePoint = gamePoint + 1;
		textScore.text = "" + gamePoint;
		if (bestScore < gamePoint) {
			bestScore = gamePoint;
			PlayerPrefs.SetInt ("bestscore", bestScore);
		}
	}

	public void EggDied () {
		gameOver = true;
		gameOverMenu.SetActive (true);
		gameSound.PlayOneShot (gameover);
		resultScoretext.text = "" + gamePoint;
		bestScoreText.text = "" + bestScore;
		timeToPlay++;
	}

	public void PlayGameAgain () {
		
		PlayerPrefs.SetInt ("colorIndex", eggColorIndex);
		SceneManager.LoadScene (2);
	}

	public void GotoShop() {
		SceneManager.LoadScene (3);
	}

	public void EggFalling () {
		eggFall = true;
	}

	public void EggJumping () {
		eggFall = false;
		gameSound.PlayOneShot (eggjump);
	}

	public void PlayGame() {
		playerPlayGame = true;
	}
}
