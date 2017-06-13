using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class EndGameChecker : MonoBehaviour {

    private IEnumerator endTimer;
    public int secondsToEnd = 10;
    private int secondsElapsed = 0;
    public Image black;
    public float fadeTime = 1.5f;
    private bool done = false;
    public GameObject EndGameText;
    public GameObject endPanel;
    public FirstPersonController playerController;

    void Start()
    {
        endTimer = countdownTimer();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && GameManager.numCollected == 4 && !done)
        {
            StartCoroutine(endTimer);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && GameManager.numCollected == 4 && !done)
        {
            StopCoroutine(endTimer);
        }
    }

    IEnumerator countdownTimer()
    {
        secondsElapsed = 0;
        while(secondsElapsed < secondsToEnd)
        {
            yield return new WaitForSeconds(1);
            secondsElapsed++;
        }
        done = true;
        StartCoroutine(FadeToBlack());
    }

    IEnumerator FadeToBlack()
    {
        black.color = Color.clear;
        float timeElapsed = 0;

        while (black.color.a <= 0.99f)
        {
            timeElapsed += Time.unscaledDeltaTime;
            black.color = new Color(0, 0, 0, timeElapsed / fadeTime);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(3);
        Time.timeScale = 0;
        playerController.m_MouseLook.SetCursorLock(false);
        EndGameText.SetActive(true);
        endPanel.SetActive(true);        
    }
}
