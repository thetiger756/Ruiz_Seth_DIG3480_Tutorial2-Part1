﻿using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
	}
}
