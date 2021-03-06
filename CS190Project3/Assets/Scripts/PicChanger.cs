﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PicChanger : MonoBehaviour {

    public enum PictureStates
    { PIC1, PIC2, PIC3, PIC4, PIC5}

    public PictureStates currentPicture;

    public Sprite[] pictures;
    public GameObject[] waypointHolders;
    public Camera myCamera;

    public SpriteRenderer blackScreen;

    private Vector3 currentDestination;
    private bool moving = true;
    public float speed;
    private byte currentAlpha;


	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        currentPicture = PictureStates.PIC1;
        myCamera.transform.position = waypointHolders[0].transform.GetChild(0).position;
        currentDestination = waypointHolders[0].transform.GetChild(1).position;
        speed = .38f;
    }
	
	// Update is called once per frame
	void Update () {
        if (moving)
        {
            float step = speed * Time.deltaTime;
            myCamera.transform.position = Vector3.MoveTowards(myCamera.transform.position, currentDestination, step);

            if (myCamera.transform.position == currentDestination)
            {
                StartCoroutine(beginTransition());
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moving = false;
            StartCoroutine(fadeIn());
        }

        

    }
    
    IEnumerator beginTransition()
    {
        moving = false;

        //fade black screen in
        for (byte i = 0; i < 250; i+=4)
        {
            currentAlpha = i;
            blackScreen.color = new Color32(0, 0, 0, i);
            yield return new WaitForSeconds(.00008f);
        }

        switch (currentPicture)
        {
            case (PictureStates.PIC1):
                {
                    myCamera.transform.position = waypointHolders[1].transform.GetChild(0).position;
                    currentDestination = waypointHolders[1].transform.GetChild(1).position;
                    GetComponent<SpriteRenderer>().sprite = pictures[1];
                    speed = .3f;

                    currentPicture = PictureStates.PIC2;
                    break;
                }
            case (PictureStates.PIC2):
                {
                    myCamera.transform.position = waypointHolders[2].transform.GetChild(0).position;
                    currentDestination = waypointHolders[2].transform.GetChild(1).position;
                    GetComponent<SpriteRenderer>().sprite = pictures[2];
                    speed = .45f;

                    currentPicture = PictureStates.PIC3;
                    break;
                }
            case (PictureStates.PIC3):
                {
                    myCamera.transform.position = waypointHolders[3].transform.GetChild(0).position;
                    currentDestination = waypointHolders[3].transform.GetChild(1).position;
                    GetComponent<SpriteRenderer>().sprite = pictures[3];
                    speed = .4f;

                    currentPicture = PictureStates.PIC4;
                    break;
                }
            case (PictureStates.PIC4):
                {
                    myCamera.transform.position = waypointHolders[4].transform.GetChild(0).position;
                    currentDestination = waypointHolders[4].transform.GetChild(1).position;
                    GetComponent<SpriteRenderer>().sprite = pictures[4];
                    speed = .4f;

                    currentPicture = PictureStates.PIC5;
                    break;
                }
            case (PictureStates.PIC5):
                {
                    SceneManager.LoadScene(1);
                    break;
                }
        }

        moving = true;

        //fade black screen out
        for (byte i = 255; i > 0; i--)
        {
            currentAlpha = i;
            blackScreen.color = new Color32(0, 0, 0, i);
            yield return new WaitForSeconds(.0008f);
        }
    }

    IEnumerator fadeIn()
    {
        AkSoundEngine.StopAll();
        for (byte i = currentAlpha; i < 255; i++)
        {
            blackScreen.color = new Color32(0, 0, 0, i);
            yield return new WaitForSeconds(.008f);
        }
        SceneManager.LoadScene(1);
    }
}

    

