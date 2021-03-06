using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {
	public Transform zombieSpawnPoints;
	public GameObject zombie;

	[Tooltip("Zombie spawn rate in secs.")]
	public float spawnRate =60f;

	private Transform [] spawnPoints;

//	private int zombieCount = 0;
//	int i =0;

	void Start () {
		spawnPoints = zombieSpawnPoints.GetComponentsInChildren<Transform>();
		print(spawnPoints.Length);
		InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
	}

	void SpawnEnemy(){
		//int i = Random.Range(1,spawnPoints.Length+1);
		Instantiate(zombie, spawnPoints[Random.Range(1, spawnPoints.Length)].position, Quaternion.identity);
		}
	}

