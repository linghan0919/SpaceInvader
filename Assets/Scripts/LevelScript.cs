using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public Button easyButton;
	public Button mediumButton;
	public Button hardButton;
	public static int level = 1;

	// Use this for initialization
	void Start () {
		Button easy = easyButton.GetComponent<Button> ();
		easy.onClick.AddListener (Easy);
		Button medium = mediumButton.GetComponent<Button> ();
		medium.onClick.AddListener (Medium);
		Button hard = hardButton.GetComponent<Button> ();
		hard.onClick.AddListener (Hard);
	}

	void Easy () {
		Debug.Log ("Easy Level");
		level = 1;
		Application.LoadLevel ("GameplayScene");
	}

	void Medium () {
		Debug.Log ("Medium Level");
		level = 2;
		Application.LoadLevel ("GameplayScene");
	}

	void Hard () {
		Debug.Log ("Hard Level");
		level = 3;
		Application.LoadLevel ("GameplayScene");
	}
}
