using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AudioLogArea : MonoBehaviour {

    public string audioLogEventName;
    public string optionalAudioLogEventName;
    public bool hasOptional;
    public bool isHouse;
    public float duration = 10f;
    private bool played;

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player") && !played)
        {
            played = true;
            /*
            if (hasOptional && GameManager.visitedHouse)
                AkSoundEngine.PostEvent(optionalAudioLogEventName, other.gameObject);
            else
                AkSoundEngine.PostEvent(audioLogEventName, other.gameObject);
            if (isHouse)
                GameManager.visitedHouse = true;
            */
            GameManager.numCollected++;

            StartCoroutine(nerfSpeed(duration));
        }
    }

    IEnumerator nerfSpeed(float duration)
    {
        controller = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
        controller.m_WalkSpeed = (1);
		controller.m_RunSpeed = (1);
        yield return new WaitForSeconds(duration);
        controller.m_WalkSpeed = (3);
		controller.m_RunSpeed = (4);
    }
}
