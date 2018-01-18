using UnityEngine;
using System.Collections;

public class BgiScript : MonoBehaviour {

	GUITexture img;
	// Use this for initialization
	void Start () {
		img = gameObject.GetComponent<GUITexture> ();
		img.pixelInset = new Rect(0, 0, Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
