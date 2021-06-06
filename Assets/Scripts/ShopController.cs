using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour {
	public static ShopController instance = null;
	[SerializeField] private Text coinText;
	[SerializeField] private Button[] buttonBuy;
	[SerializeField] private GameObject[] costText;
	[SerializeField] private GameObject[] eggColor;
	[SerializeField] private GameObject[] chooseEggs;
	[SerializeField] private Sprite buttonImage;
	private int eggName;
	private int coinPoint;
	private int egg2Cost = 20;
	private int egg3Cost = 30;
	private int egg4Cost = 40;
	private int egg5Cost = 50;
	private int egg6Cost = 60;
	private int egg7Cost = 70;
	private int egg8Cost = 80;
	private int egg9Cost = 90;
	private int egg10Cost = 100;
	private int egg11Cost = 110;
	private int egg12Cost = 120;
	private int egg13Cost = 130;
	private int egg14Cost = 140;
	private int egg15Cost = 150;
	private int egg16Cost = 160;
	private string egg2Buy, egg3Buy, egg4Buy, egg5Buy, egg6Buy, egg7Buy, egg8Buy, egg9Buy, egg10Buy, egg11Buy, egg12Buy, egg13Buy, egg14Buy, egg15Buy,  egg16Buy; 

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	void Start() {
		coinPoint = PlayerPrefs.GetInt ("coinPoint", coinPoint);
		coinText.text = "" + coinPoint;
		egg2Buy = PlayerPrefs.GetString("egg2Buy",egg2Buy);
		egg3Buy = PlayerPrefs.GetString ("egg3Buy", egg3Buy);
		egg4Buy = PlayerPrefs.GetString ("egg4Buy", egg4Buy);
		egg5Buy = PlayerPrefs.GetString ("egg5Buy", egg5Buy);
		egg6Buy = PlayerPrefs.GetString ("egg6Buy", egg6Buy);
		egg7Buy = PlayerPrefs.GetString ("egg7Buy", egg7Buy);
		egg8Buy = PlayerPrefs.GetString ("egg8Buy", egg8Buy);
		egg9Buy = PlayerPrefs.GetString ("egg9Buy", egg9Buy);
		egg10Buy = PlayerPrefs.GetString ("egg10Buy", egg10Buy);
		egg11Buy = PlayerPrefs.GetString ("egg11Buy", egg11Buy);
		egg12Buy = PlayerPrefs.GetString ("egg12Buy", egg12Buy);
		egg13Buy = PlayerPrefs.GetString ("egg13Buy", egg13Buy);
		egg14Buy = PlayerPrefs.GetString ("egg14Buy", egg14Buy);
		egg15Buy = PlayerPrefs.GetString ("egg15Buy", egg15Buy);
		egg16Buy = PlayerPrefs.GetString ("egg16Buy", egg16Buy);
		if (egg2Buy == "yes") {
			buttonBuy [1].image.overrideSprite = buttonImage;
			costText [0].SetActive (false);
			eggColor [1].SetActive (true);
		}
		if (egg3Buy == "yes") {
			buttonBuy [2].image.overrideSprite = buttonImage;
			costText [1].SetActive (false);
			eggColor [2].SetActive (true);
		}
		if (egg4Buy == "yes") {
			buttonBuy [3].image.overrideSprite = buttonImage;
			costText [2].SetActive (false);
			eggColor [3].SetActive (true);
		}
		if (egg5Buy == "yes") {
			buttonBuy [4].image.overrideSprite = buttonImage;
			costText [3].SetActive (false);
			eggColor [4].SetActive (true);
		}
		if (egg6Buy == "yes") {
			buttonBuy [5].image.overrideSprite = buttonImage;
			costText [4].SetActive (false);
			eggColor [5].SetActive (true);
		}
		if (egg7Buy == "yes") {
			buttonBuy [6].image.overrideSprite = buttonImage;
			costText [5].SetActive (false);
			eggColor [6].SetActive (true);
		}
		if (egg8Buy == "yes") {
			buttonBuy [7].image.overrideSprite = buttonImage;
			costText [6].SetActive (false);
			eggColor [7].SetActive (true);
		}
		if (egg9Buy == "yes") {
			buttonBuy [8].image.overrideSprite = buttonImage;
			costText [7].SetActive (false);
			eggColor [8].SetActive (true);
		}
		if (egg10Buy == "yes") {
			buttonBuy [9].image.overrideSprite = buttonImage;
			costText [8].SetActive (false);
			eggColor [9].SetActive (true);
		}
		if (egg11Buy == "yes") {
			buttonBuy [10].image.overrideSprite = buttonImage;
			costText [9].SetActive (false);
			eggColor [10].SetActive (true);
		}
		if (egg12Buy == "yes") {
			buttonBuy [11].image.overrideSprite = buttonImage;
			costText [10].SetActive (false);
			eggColor [11].SetActive (true);
		}
		if (egg13Buy == "yes") {
			buttonBuy [12].image.overrideSprite = buttonImage;
			costText [11].SetActive (false);
			eggColor [12].SetActive (true);
		}
		if (egg14Buy == "yes") {
			buttonBuy [13].image.overrideSprite = buttonImage;
			costText [12].SetActive (false);
			eggColor [13].SetActive (true);
		}
		if (egg15Buy == "yes") {
			buttonBuy [14].image.overrideSprite = buttonImage;
			costText [13].SetActive (false);
			eggColor [14].SetActive (true);
		}
		if (egg16Buy == "yes") {
			buttonBuy [15].image.overrideSprite = buttonImage;
			costText [14].SetActive (false);
			eggColor [15].SetActive (true);
		}
	}

	public void ChooseEgg1() {
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 0) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		eggName = 0;
		PlayerPrefs.SetInt ("eggName", eggName);
		SceneManager.LoadScene (2);
	}

	public void ChooseEgg2() {
		if (egg2Cost <= coinPoint && egg2Buy != "yes") {
			coinPoint = coinPoint - egg2Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg2Buy = "yes";
			PlayerPrefs.SetString ("egg2Buy", egg2Buy);
			buttonBuy [1].image.overrideSprite = buttonImage;
			costText [0].SetActive (false);
			eggColor [1].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 1) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg2Buy == "yes") {
			eggName = 1;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg3() {
		if (egg3Cost <= coinPoint && egg3Buy != "yes") {
			coinPoint = coinPoint - egg3Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg3Buy = "yes";
			PlayerPrefs.SetString ("egg3Buy", egg3Buy);
			buttonBuy [2].image.overrideSprite = buttonImage;
			costText [1].SetActive (false);
			eggColor [2].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 2) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg3Buy == "yes") {
			eggName = 2;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg4() {
		if (egg4Cost <= coinPoint && egg4Buy != "yes") {
			coinPoint = coinPoint - egg4Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg4Buy = "yes";
			PlayerPrefs.SetString ("egg4Buy", egg4Buy);
			buttonBuy [3].image.overrideSprite = buttonImage;
			costText [2].SetActive (false);
			eggColor [3].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 3) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg4Buy == "yes") {
			eggName = 3;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg5() {
		if (egg5Cost <= coinPoint && egg5Buy != "yes") {
			coinPoint = coinPoint - egg5Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg5Buy = "yes";
			PlayerPrefs.SetString ("egg5Buy", egg5Buy);
			buttonBuy [4].image.overrideSprite = buttonImage;
			costText [3].SetActive (false);
			eggColor [4].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 4) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg5Buy == "yes") {
			eggName = 4;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg6() {
		if (egg6Cost <= coinPoint && egg6Buy != "yes") {
			coinPoint = coinPoint - egg6Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg6Buy = "yes";
			PlayerPrefs.SetString ("egg6Buy", egg6Buy);
			buttonBuy [5].image.overrideSprite = buttonImage;
			costText [4].SetActive (false);
			eggColor [5].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 5) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg6Buy == "yes") {
			eggName = 5;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg7() {
		if (egg7Cost <= coinPoint && egg7Buy != "yes") {
			coinPoint = coinPoint - egg7Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg7Buy = "yes";
			PlayerPrefs.SetString ("egg7Buy", egg7Buy);
			buttonBuy [6].image.overrideSprite = buttonImage;
			costText [5].SetActive (false);
			eggColor [6].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 6) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg7Buy == "yes") {
			eggName = 6;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg8() {
		if (egg8Cost <= coinPoint && egg8Buy != "yes") {
			coinPoint = coinPoint - egg8Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg8Buy = "yes";
			PlayerPrefs.SetString ("egg8Buy", egg8Buy);
			buttonBuy [7].image.overrideSprite = buttonImage;
			costText [6].SetActive (false);
			eggColor [7].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 7) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg8Buy == "yes") {
			eggName = 7;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg9() {
		if (egg9Cost <= coinPoint && egg9Buy != "yes") {
			coinPoint = coinPoint - egg9Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg9Buy = "yes";
			PlayerPrefs.SetString ("egg9Buy", egg9Buy);
			buttonBuy [8].image.overrideSprite = buttonImage;
			costText [7].SetActive (false);
			eggColor [8].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 8) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg9Buy == "yes") {
			eggName = 8;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg10() {
		if (egg10Cost <= coinPoint && egg10Buy != "yes") {
			coinPoint = coinPoint - egg10Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg10Buy = "yes";
			PlayerPrefs.SetString ("egg10Buy", egg10Buy);
			buttonBuy [9].image.overrideSprite = buttonImage;
			costText [8].SetActive (false);
			eggColor [9].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 9) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg10Buy == "yes") {
			eggName = 9;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg11() {
		if (egg11Cost <= coinPoint && egg11Buy != "yes") {
			coinPoint = coinPoint - egg11Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg11Buy = "yes";
			PlayerPrefs.SetString ("egg11Buy", egg11Buy);
			buttonBuy [10].image.overrideSprite = buttonImage;
			costText [9].SetActive (false);
			eggColor [10].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 10) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg11Buy == "yes") {
			eggName = 10;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg12() {
		if (egg12Cost <= coinPoint && egg12Buy != "yes") {
			coinPoint = coinPoint - egg12Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg12Buy = "yes";
			PlayerPrefs.SetString ("egg12Buy", egg12Buy);
			buttonBuy [11].image.overrideSprite = buttonImage;
			costText [10].SetActive (false);
			eggColor [11].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 11) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg12Buy == "yes") {
			eggName = 11;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg13() {
		if (egg13Cost <= coinPoint && egg13Buy != "yes") {
			coinPoint = coinPoint - egg13Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg13Buy = "yes";
			PlayerPrefs.SetString ("egg13Buy", egg13Buy);
			buttonBuy [12].image.overrideSprite = buttonImage;
			costText [11].SetActive (false);
			eggColor [12].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 12) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg13Buy == "yes") {
			eggName = 12;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg14() {
		if (egg14Cost <= coinPoint && egg14Buy != "yes") {
			coinPoint = coinPoint - egg14Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg14Buy = "yes";
			PlayerPrefs.SetString ("egg14Buy", egg14Buy);
			buttonBuy [13].image.overrideSprite = buttonImage;
			costText [12].SetActive (false);
			eggColor [13].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 13) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg14Buy == "yes") {
			eggName = 13;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg15() {
		if (egg15Cost <= coinPoint && egg15Buy != "yes") {
			coinPoint = coinPoint - egg15Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg15Buy = "yes";
			PlayerPrefs.SetString ("egg15Buy", egg15Buy);
			buttonBuy [14].image.overrideSprite = buttonImage;
			costText [13].SetActive (false);
			eggColor [14].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 14) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg15Buy == "yes") {
			eggName = 14;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ChooseEgg16() {
		if (egg16Cost <= coinPoint && egg16Buy != "yes") {
			coinPoint = coinPoint - egg16Cost;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
			egg16Buy = "yes";
			PlayerPrefs.SetString ("egg16Buy", egg16Buy);
			buttonBuy [15].image.overrideSprite = buttonImage;
			costText [14].SetActive (false);
			eggColor [15].SetActive (true);
		}
		for (int i = 0; i < chooseEggs.Length; i++) {
			if (i == 15) {
				chooseEggs [i].SetActive (true);
			} else {
				chooseEggs [i].SetActive (false);
			}
		}
		if (egg16Buy == "yes") {
			eggName = 15;
			PlayerPrefs.SetInt ("eggName", eggName);
			SceneManager.LoadScene (2);
		}
	}

	public void ReturnMenu () {
		SceneManager.LoadScene (1);
	}

	public void OnWatchVideoRewarded(){
		//UnityAdsController.instance.continues = WatchvideoDelegates;
		//UnityAdsController.instance.ShowAd ();
	}
	[HideInInspector]
	public void WatchvideoDelegates(bool success){
		if(success){
			coinPoint = coinPoint + 10;
			coinText.text = "" + coinPoint;
			PlayerPrefs.SetInt ("coinPoint", coinPoint);
		}
	}
}
