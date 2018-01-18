using UnityEngine;
using System.Collections;

public class ScoreUI : MonoBehaviour {

	GlobalScript gs;
	GUIText scoreText;

	// Use this for initialization
	void Start () {
		GameObject globalObject = GameObject.Find ("GlobalObject");
		gs = globalObject.GetComponent<GlobalScript> ();
		scoreText = gameObject.GetComponent<GUIText> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = " Score: " + gs.score.ToString ();
	}
}
