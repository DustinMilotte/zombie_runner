using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {
	private Transform [] spawnPoints;
	public GameObject zombieSpawnPoints;
	public GameObject zombie;
	public float spawnTime = 5f;

//	private int zombieCount = 0;
//	int i =0;

	void Start () {
		spawnPoints = zombieSpawnPoints.GetComponentsInChildren<Transform>();
		InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
	}

	void SpawnEnemy(){
		Instantiate(zombie,spawnPoints[Random.Range(0,2)].position, Quaternion.identity);
		}
	}

