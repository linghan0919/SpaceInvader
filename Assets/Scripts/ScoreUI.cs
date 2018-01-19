using UnityEngine;
using System.Collections;

public class ScoreUI : MonoBehaviour {

	GlobalScript gs;
	GUIText scoreText;

	// Use this for initialization
	void Start () {
		scoreText = gameObject.GetComponent<GUIText> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + GlobalScript.score.ToString ();
	}
}
