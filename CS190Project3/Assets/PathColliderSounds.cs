using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathColliderSounds : MonoBehaviour {

    public string EventName;

    private int stop = 0;

    private bool inZone = false;

    public void beginSounds()
    {
        AkSoundEngine.SetRTPCValue("EventVolume", 100);
        AkSoundEngine.PostEvent(EventName, this.gameObject);
    }
}
