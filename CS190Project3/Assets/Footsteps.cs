﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FootstepPlay(){
		AkSoundEngine.PostEvent("Footsteps", this.gameObject);
	}
}
