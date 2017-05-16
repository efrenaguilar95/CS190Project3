using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour {

    public Text displayText;
    private bool pickedUp = false;
    private Color textColor;

	// Use this for initialization
	void Start () {
        textColor = displayText.color;
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.E))
        {
            pickedUp = true;
            textColor.a = 0;
            displayText.color = textColor;
            //code to tell gameManager that the object was picked up
        }
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !pickedUp)
        {
            textColor.a = 1;
            displayText.color = textColor;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player" && !pickedUp)
        {
            textColor.a = 0;
            displayText.color = textColor;
        }
    }
}
