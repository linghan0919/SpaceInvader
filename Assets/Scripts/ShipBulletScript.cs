using UnityEngine;
using System.Collections;

public class ShipBulletScript : MonoBehaviour {

	public Vector3 thrust;

	// Use this for initialization
	void Start () {
		thrust.z = 400.0f;
		GetComponent<Rigidbody> ().drag = 0;
		GetComponent<Rigidbody> ().AddRelativeForce (thrust);
	}

	void Update() {

		// clear bullet if they are too far away
		if (gameObject.transform.position.z >= 15)
			Destroy (gameObject);
	}


	void OnCollisionEnter(Collision collision) {
		Collider collider = collision.collider;

		if (collider.CompareTag ("Alien")) {
			AlienScript alien = collider.gameObject.GetComponent<AlienScript>();
			alien.Die();
			Destroy(gameObject);
		}
		else if (collider.CompareTag("Fort")) {
			Debug.Log ("collided with fort");
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
