using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathColliderSounds : MonoBehaviour {

    public string EventName;

    private int stop = 0;

    private bool inZone = false;

    // Use this for initialization
    void Start () {
        if (stop == 0)
        {
            stop++;
            AkSoundEngine.PostEvent(EventName, this.gameObject);
            AkSoundEngine.SetRTPCValue("EventVolume", 0);
            print("YOO");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && !inZone)
        {
            print("OOOP");
            AkSoundEngine.SetRTPCValue("EventVolume", 100);
            inZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && inZone)
        {
            AkSoundEngine.SetRTPCValue("EventVolume", 0);
            inZone = false;
        }
    }
}
