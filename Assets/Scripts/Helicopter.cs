using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
	public Transform target;
	public float speed = 1f;

	private bool heliCalled = false;
	private Rigidbody rigidBody;


	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Update (){
		if(heliCalled){
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		}
	}

	void OnDispatchHelicopter (){
		Debug.Log ("Heli called");
		heliCalled = true;			
	}

}
