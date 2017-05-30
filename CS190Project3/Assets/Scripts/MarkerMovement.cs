using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerMovement : MonoBehaviour {

    public static float speed = 1.0f;
    public static bool move;
    public Transform target;

    //Debugging purposes
    public bool startMove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //only really used for debugging purposes
        if (startMove)
            move = true;
		
	}

    void FixedUpdate()
    {
        if(move)
        {
            float step = speed * Time.deltaTime;
            Vector3 targetDir = target.position - transform.position;
            targetDir.y = 0;
            Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        }
    }
}
