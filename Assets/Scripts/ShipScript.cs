using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {

	private Transform ship;
	public float speed;
	public float maxBound, minBound;
	public GameObject shipBullet;
	public float fireRate;
	public AudioClip deathSound;

	private float nextFire;

	// Use this for initialization
	void Start () {
		ship = GetComponent<Transform> ();
		speed = 0.1f;
		maxBound = 10.0f;
		minBound = -10.0f;
	}

	// Use to control the movement of the ship
	void FixedUpdate () {
		float xInput = Input.GetAxisRaw ("Horizontal");

		// if out of bound, cannot move
		if (ship.position.x < minBound && xInput < 0) {
			xInput = 0;
		} else if (ship.position.x > maxBound && xInput > 0) {
			xInput = 0;
		}

		ship.position += Vector3.right * xInput * speed;
	}

	void Update() {
		if (Input.GetKeyDown ("space") && Time.time > nextFire) {
			Debug.Log ("Player's ship fire");
			nextFire = Time.time + fireRate;
			Vector3 bulletPos = ship.position;
			bulletPos.z += 1;
			Instantiate(shipBullet, bulletPos, Quaternion.identity);
		}
	}

	public void Die() {
		AudioSource.PlayClipAtPoint (deathSound, gameObject.transform.position);
		GlobalScript.result = false;
		Destroy (gameObject);
		Application.LoadLevel ("WinloseScene");
	}
}
