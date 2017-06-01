using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour {

    private bool fadedIn = true;
    private bool animating = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fadedIn && !animating)
        {
            animating = true;
            StartCoroutine(fadeOut());
        }
        if (!fadedIn && !animating)
        {
            animating = true;
            StartCoroutine(fadeIn());
        }
	}

    IEnumerator fadeOut()
    {
        for (byte i = 255; i > 0; i--)
        {
            GetComponent<Text>().color = new Color32(0, 0, 0, i);
            yield return new WaitForSeconds(.002f);
        }
        yield return new WaitForSeconds(1f);
        fadedIn = false;
        animating = false;
    }
    IEnumerator fadeIn()
    {
        for (byte i = 0; i < 255; i++)
        {
            GetComponent<Text>().color = new Color32(0, 0, 0, i);
            yield return new WaitForSeconds(.005f);
        }
        yield return new WaitForSeconds(2.5f);
        fadedIn = true;
        animating = false;
    }
}
