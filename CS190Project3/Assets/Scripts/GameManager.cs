using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public enum State // If the player is triggering environment sounds (ie. wolves)
    {
        SAFE,
        INZONE,
        DEAD
    }
    public State playerState;

    public enum Collected // Which collectible the player is on (ASSUMES LINEARITY)
    {
        LOG1,
        LOG2,
        LOG3,
        LOG4,
        LOG5,
        LOG6,
        LOG7,
        LOG8,
        DONE
    }
    public Collected playerCollected;

    public GameObject player;
    public GameObject sensor;

	// Use this for initialization
	void Start () {
        playerState = State.SAFE;
        playerCollected = Collected.LOG1;

	}

    // Update is called once per frame
    void Update()
    {
        switch (playerState)
        {
            case State.SAFE:
                {
                    break;
                }
            case State.INZONE:
                {
                    //do things with volume/balance depending on distance from emitter
                    break;
                }
            case State.DEAD:
                {
                    //kill the player for being in the death zone
                    break;
                }
        }
    }

    public void inZonePlayer()
    {
        if (playerState != State.INZONE)
        {
            playerState = State.INZONE;
            print("in the zone");
        }
    }
    public void killPlayer()
    {
        if (playerState != State.DEAD)
        { 
            print("dead boys");
            playerState = State.DEAD;
        }
    }
    public void safePlayer()
    {
        if (playerState != State.SAFE)
        {
            print("safe!");
            playerState = State.SAFE;
        }
    }
}
