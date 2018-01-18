using UnityEngine;
using System.Collections;

public class AlienScript : MonoBehaviour {

	public GameObject deathExplosion;
	public int pointValue;

	// Use this for initialization
	void Start () {
		pointValue = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Die() {
		Instantiate (deathExplosion, gameObject.transform.position, Quaternion.identity);
		GameObject globalObj = GameObject.Find ("GlobalObject");
		GlobalScript gs = globalObj.GetComponent<GlobalScript> ();
		gs.score += pointValue;

		Destroy (gameObject);
	}
}
