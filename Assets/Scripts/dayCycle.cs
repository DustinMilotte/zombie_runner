using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayCycle : MonoBehaviour {
	[Tooltip ("Set a value of minutes per second, try 60")]
	public float timeScale;
	
	// Update is called once per frame
	void Update () {
		float degreesPerSecond = 360f / (60f * 60f * 24f); 
		float angleThisFrame = Time.deltaTime * timeScale * degreesPerSecond; 
		transform.Rotate(angleThisFrame, 0, 0);
	}
}
