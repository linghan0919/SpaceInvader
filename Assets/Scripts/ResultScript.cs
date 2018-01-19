using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultScript : MonoBehaviour {

	public Text result;
	public Text score;
	public Button newgameButton;
	public Button homeButton;

	// Use this for initialization
	void Start () {
		if (GlobalScript.result) 
			result.text = "You Win! :)";
		else
			result.text = "Game Over! :(";

		score.text = "Score: " + GlobalScript.score.ToString ();

		Button newgame = newgameButton.GetComponent<Button> ();
		newgame.onClick.AddListener (NewGame);
		Button home = homeButton.GetComponent<Button> ();
		home.onClick.AddListener (Home);
	}
	
	void NewGame () {
		Debug.Log ("click New Game Button");
		Application.LoadLevel ("GameplayScene");
	}
	
	void Home () {
		Debug.Log ("click Home Button");
		Application.LoadLevel ("HomeScene");
	}
}
