using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {


    public float timer = 0; //Timer variable.


    void Timer()
    {
        timer = timer + 1; //This is to make the timer add a second each second, instead of each frame.
        Debug.Log(string.Format("Timer: {0}", timer * Time.deltaTime));
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timer();
    }
}
