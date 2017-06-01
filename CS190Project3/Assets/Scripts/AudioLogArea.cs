using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLogArea : MonoBehaviour {

    public string audioLogEventName;
    public string optionalAudioLogEventName;
    public bool hasOptional;
    public bool isHouse;
    private bool played;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player") && !played)
        {
            played = true;
            if (hasOptional && GameManager.visitedHouse)
                AkSoundEngine.PostEvent(optionalAudioLogEventName, other.gameObject);
            else
                AkSoundEngine.PostEvent(audioLogEventName, other.gameObject);
            if (isHouse)
                GameManager.visitedHouse = true;

            GameManager.numCollected++;
        }
    }
}
