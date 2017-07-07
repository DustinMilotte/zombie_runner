using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMute : MonoBehaviour {
	
	public bool mute;

	void Update (){
		if(mute){
			AudioListener.pause = true;
		}else{
			AudioListener.pause = false;
		}
	}
}
