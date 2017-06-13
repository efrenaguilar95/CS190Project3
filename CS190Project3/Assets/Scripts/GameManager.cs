using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public enum State // If the player is triggering environment sounds (ie. wolves)
    {
        SAFE,
        INZONE,
        DEAD
    }
    public State playerState;


    public static int numCollected;

    public GameObject player;
    public FirstPersonController playerController;
    public static bool visitedHouse = false;

	// Use this for initialization
	void Start () {
        playerState = State.SAFE;

	}

    // Update is called once per frame
    void Update()
    {
		if (numCollected == 4)
			MarkerMovement.move = true;
    }


    public void Resume()
    {
        playerController.UnPause();
    }

    public void Restart()
    {
        AkSoundEngine.StopAll();
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public static void KillPlayer()
    {
        AkSoundEngine.StopAll();
        SceneManager.LoadScene(0);
    }
}
