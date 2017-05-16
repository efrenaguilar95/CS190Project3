﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPathCollider : MonoBehaviour {

    public GameObject gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameManager.GetComponent<GameManager>().killPlayer();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameManager.GetComponent<GameManager>().inZonePlayer();
        }
    }
}
