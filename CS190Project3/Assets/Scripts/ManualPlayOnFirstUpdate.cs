using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualPlayOnFirstUpdate : MonoBehaviour {

	[SerializeField] string eventName;

	private int stop = 0;

	// Update is called once per frame
	void Update () {
		if (stop == 0)
		{
			stop++;
			AkSoundEngine.PostEvent(eventName, this.gameObject);
		}

	}
}
