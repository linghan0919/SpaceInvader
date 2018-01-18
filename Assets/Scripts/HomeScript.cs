using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HomeScript : MonoBehaviour {

	public Button newgameButton;
	//public levelButton;
	//public exitButton;

	// Use this for initialization
	void Start () {
		Button newgame = newgameButton.GetComponent<Button> ();
		newgame.onClick.AddListener (NewGame);
	}
	
	// Update is called once per frame
	void NewGame () {
		Debug.Log ("click New Game Button");
		Application.LoadLevel ("GameplayScene");
	}
}
