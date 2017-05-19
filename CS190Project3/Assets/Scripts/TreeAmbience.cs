using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAmbience : MonoBehaviour {

    private int stop = 0;

	// Use this for initialization
	void Start () {
        AkSoundEngine.PostEvent("Leaves", this.gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (stop == 0)
        {
            stop++;
            AkSoundEngine.PostEvent("Leaves", this.gameObject);
        }

        }
}
