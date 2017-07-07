using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayCycle : MonoBehaviour {
	[Tooltip ("Length of in-game day in minutes")]
	public int lengthOfDay = 6;

	private float degreesPerSecond = 0f;

	void Start() {
		degreesPerSecond = 360f / ((float)lengthOfDay * 60f);
	}

	void Update () { 
		transform.RotateAround(transform.position, Vector3.forward, degreesPerSecond * Time.deltaTime); 
	}
}
