﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(2); //or whatever number your scene is

    }
}

