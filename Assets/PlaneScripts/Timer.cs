using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{


    public float timer = 0; //Timer variable.


    void TimerObject()
    {
        timer += Time.deltaTime; //To make the number follow the Time.deltaTime format, and work only each second.
        Debug.Log(string.Format("Timer: {0}", timer)); //To display the time.
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TimerObject(); //To run the timer.
    }
}
