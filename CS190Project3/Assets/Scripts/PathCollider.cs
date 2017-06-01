using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCollider : MonoBehaviour {


    public GameObject gameManager;
    private bool triggered = false;

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
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
   
        }
    }
}
