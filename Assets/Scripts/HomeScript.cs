using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HomeScript : MonoBehaviour {

	public Button newgameButton;
	public Button levelButton;
	public Button exitButton;

	// Use this for initialization
	void Start () {
		Button newgame = newgameButton.GetComponent<Button> ();
		newgame.onClick.AddListener (NewGame);
		Button level = levelButton.GetComponent<Button> ();
		level.onClick.AddListener (LevelChoose);
		Button exit = exitButton.GetComponent<Button> ();
		exit.onClick.AddListener (Exit);
	}

	void NewGame () {
		Debug.Log ("click New Game Button");
		Application.LoadLevel ("GameplayScene");
	}

	void LevelChoose () {
		Debug.Log ("click Level Choose Button");
		Application.LoadLevel ("LevelScene");
	}

	void Exit() {
		Debug.Log ("click Exit Button");
		Application.Quit ();
	}
}
