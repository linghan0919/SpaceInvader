using UnityEngine;
using System.Collections;

public class LevelUI : MonoBehaviour {

	GUIText levelText;

	// Use this for initialization
	void Start () {
		levelText = gameObject.GetComponent<GUIText> ();

		Debug.Log (LevelScript.level);
		if (LevelScript.level == 1) {
			levelText.text = "Level: Easy";
		} else if (LevelScript.level == 2) {
			levelText.text = "Level: Medium";
		} else {
			levelText.text = "Level: Hard";
		}
	}
}
