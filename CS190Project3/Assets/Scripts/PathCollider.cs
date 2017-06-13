using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCollider : MonoBehaviour {


    public GameObject gameManager;
    private bool triggered = false;
    private static bool firstTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && !triggered)
        {
            this.GetComponentInChildren<PathColliderSounds>().beginSounds();
            triggered = true;
            if(!firstTrigger)
            {
                //AkSoundEngine.PostEvent("Danger_Wolves", other.gameObject);
                firstTrigger = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
   
        }
    }
}
