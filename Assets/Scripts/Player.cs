using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public bool reSpawn = false;
	public Transform [] spawnPoints;

	private GameObject playerSpawnPoints;
	private bool toggleSwitch= false;

	// Use this for initialization
	void Start () {
		playerSpawnPoints = GameObject.Find("Player Spawn Points");
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (toggleSwitch != reSpawn) {
			ReSpawn ();
			reSpawn = false;
		} 
	}

	void ReSpawn(){
		transform.position = spawnPoints[Random.Range(1, spawnPoints.Length)].transform.position;
	}
}
