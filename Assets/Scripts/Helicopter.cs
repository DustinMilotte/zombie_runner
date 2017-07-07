using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	private bool called;
	private Rigidbody rigidBody;


	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}

	void OnDispatchHelicopter (){
		Debug.Log ("Heli called");
		called = true;			
		rigidBody.velocity = new Vector3 (0f, 0f, 50f);
	}

}
