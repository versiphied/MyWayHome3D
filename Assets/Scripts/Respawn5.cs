﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(4);

    }
}
