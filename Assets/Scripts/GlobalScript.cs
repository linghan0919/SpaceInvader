using UnityEngine;
using System.Collections;

public class GlobalScript : MonoBehaviour {

	public static int score = 0;
	public static bool result = false;
	public AudioClip bgm;

	// Use this for initialization
	void Start () {
		score = 0;
		result = false;
		AudioSource.PlayClipAtPoint (bgm, gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
