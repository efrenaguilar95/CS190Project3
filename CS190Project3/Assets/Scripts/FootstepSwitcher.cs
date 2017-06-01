using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSwitcher : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag.Equals("Player"))
		{
			AkSoundEngine.SetSwitch("Footstep_Switch", "Inside", other.gameObject);
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag.Equals("Player"))
		{
			AkSoundEngine.SetSwitch("Footstep_Switch", "Outside", other.gameObject);
		}
	}
}
