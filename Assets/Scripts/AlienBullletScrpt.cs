using UnityEngine;
using System.Collections;

public class AlienBullletScrpt : MonoBehaviour {

	public Vector3 thrust;

	// Use this for initialization
	void Start () {
		thrust.z = -400.0f;
		GetComponent<Rigidbody> ().drag = 0;
		GetComponent<Rigidbody> ().AddRelativeForce (thrust);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.z <= -10)
			Destroy (gameObject);
	}

	void OnCollisionEnter(Collision collision) {
		Collider collider = collision.collider;
		
		if (collider.CompareTag ("Ship")) {
			ShipScript ship = collider.gameObject.GetComponent<ShipScript>();
			ship.Die();
			Destroy(gameObject);
		} 
		else if (collider.CompareTag("Fort")) {
			FortScript fort = collider.gameObject.GetComponent<FortScript>();
			fort.life -= 1;
			Destroy(gameObject);
		}
		else {
			Debug.Log ("collided with " + collider.tag);
			Destroy(gameObject);
		}
	}
}
