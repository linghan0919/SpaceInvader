﻿using UnityEngine;
using System.Collections;

public class FortScript : MonoBehaviour {

	public int life = 3;

	// Update is called once per frame
	void Update () {
		if (life <= 0)
			Destroy (gameObject);
	}
}
