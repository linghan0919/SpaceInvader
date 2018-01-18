using UnityEngine;
using System.Collections;

public class AlienGroup : MonoBehaviour {

	private Transform alienGroup;
	public GameObject alienBullet;
	public float speed;
	public float fireRate;

	// Use this for initialization
	void Start () {
		speed = 0.5f;
		fireRate = 0.99f; // to change later
		InvokeRepeating ("MoveAlien", 0.1f, 0.3f);
		alienGroup = GetComponent<Transform> ();
	}

	void MoveAlien () {
		alienGroup.position += Vector3.right * speed;

		foreach (Transform alien in alienGroup) {
			if (alien.position.x < -12 || alien.position.x > 12) {
				speed = -speed;
				alienGroup.position += Vector3.back * 0.5f;
				return;
			}

			if(Random.value > fireRate) {
				Vector3 bulletPos = alien.position;
				bulletPos.z -= 1;
				Instantiate(alienBullet, bulletPos, Quaternion.identity);
			}

		}
	}
}
