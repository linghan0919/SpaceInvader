using UnityEngine;
using System.Collections;

public class BgImgScript : MonoBehaviour {

	public GUITexture gui;
	// Use this for initialization
	void Start () {
		gui = GetComponent<GUITexture> ();
		gui.pixelInset = new Rect (0, 0, Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
