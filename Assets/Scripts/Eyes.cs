using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultFOV;
	private bool zoomed = false;


	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera>();
		defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Zoom") && !zoomed){
			eyes.fieldOfView = 1.5f*defaultFOV;
			zoomed = true;
		} else if (Input.GetButtonDown("Zoom")){
			eyes.fieldOfView = defaultFOV;
			zoomed = false;
		}
	}
}
