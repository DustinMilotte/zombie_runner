﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject landingArea;

	private GameObject playerSpawnPoints;
	private bool toggleSwitch= false;
	private bool reSpawn = false;
 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnFindClearArea(){
		Invoke ("DropFlare", 3f);
	}

	void DropFlare(){
		Instantiate (landingArea);
	}
}
