using UnityEngine;
using System.Collections;

public class AlienGroup : MonoBehaviour {

	private Transform alienGroup;
	public GameObject alienBullet;
	public float speed;
	public float fireRate;

	// Use this for initialization
	void Start () {
		if (LevelScript.level == 1) {
			fireRate = 0.99f;
			speed = 0.5f;
		} else if (LevelScript.level == 2) {
			fireRate = 0.95f;
			speed = 0.7f;
		} else {
			fireRate = 0.9f;
			speed = 0.9f;
		}
		InvokeRepeating ("MoveAlien", 0.1f, 0.3f);
		alienGroup = GetComponent<Transform> ();
	}

	void MoveAlien () {
		alienGroup.position += Vector3.right * speed;

		foreach (Transform alien in alienGroup) {
			if (alien.position.x < -9.0f || alien.position.x > 9.0f) {
				speed = -speed;
				alienGroup.position += Vector3.back * 0.5f;
				return;
			}

			if(Random.value > fireRate) {
				Vector3 bulletPos = alien.position;
				bulletPos.z -= 1;
				Instantiate(alienBullet, bulletPos, Quaternion.identity);
			}

			if(alien.position.z <= -3.5f) {
				GlobalScript.result = false;
				Application.LoadLevel ("WinloseScene");
			}

		}

		/*if (alienGroup.childCount == 1) {
			CancelInvoke();
			InvokeRepeating("MoveAlien", 0.1f, 0.25f);
		}*/

		if (alienGroup.childCount == 0) {
			GlobalScript.result = true;
			Application.LoadLevel ("WinloseScene");
		}
	}
}
