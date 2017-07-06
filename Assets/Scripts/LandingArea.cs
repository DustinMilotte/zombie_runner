using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingArea : MonoBehaviour {
	public float timeSinceLastTrigger = 0;

	private bool foundClearArea = false;

	void Update(){
		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger >= 1f && !foundClearArea && Time.realtimeSinceStartup > 10f) {
			foundClearArea = true;
			SendMessageUpwards ("OnFindClearArea");
		}
	}

	void OnTriggerStay(Collider col){
		if (col.tag != "Player") {
			timeSinceLastTrigger = 0f;
		}
	}

}
