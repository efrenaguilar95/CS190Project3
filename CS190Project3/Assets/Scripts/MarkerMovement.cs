using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerMovement : MonoBehaviour {

    public static float speed = 1.0f;   //ramp speed from 0 to ~2 over, say, 8 seconds or something?
                                        //test to make sure even players who are confused or initially unaware can make it
    public static bool move;
    public Transform target;
    private bool coroutineCalled = false;
    private bool delayCoroutineCalled = false;
    private bool delayDone = false;

    //Debugging purposes
    public bool startMove;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        //only really used for debugging purposes
        if (startMove)
            move = true;

    }

    void FixedUpdate()
    {
        if (move)
        {
            if (!delayCoroutineCalled)
            {
                StartCoroutine(moveDelay());
                delayCoroutineCalled = true;
            }
        }

        if (delayDone)
        {
            if (!coroutineCalled)
            {
                StartCoroutine(increaseSpeed());
                coroutineCalled = true;
            }
            float step = speed * Time.deltaTime;
            Vector3 targetDir = target.position - transform.position;
            targetDir.y = 0;
            Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        }
   }   

    IEnumerator increaseSpeed()
    {
        while (speed < 2)
        {
            yield return new WaitForSeconds(2);
            speed += .08f;
        }
    }

    IEnumerator moveDelay()
    {
        yield return new WaitForSeconds(20);
        delayDone = true;
    }
}
