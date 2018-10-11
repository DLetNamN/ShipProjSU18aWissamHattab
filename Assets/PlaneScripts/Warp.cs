using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{



    void Warps()
    {
        if (transform.position.y >= 6.3) //This checks if the plane is above 6.30 on the Y axis, which is slightly off-screen
        {
            transform.position = new Vector3(0, -4.8f, 0); //This sends the plane to the opposite side.
        }
        if (transform.position.y <= -6.30) //This does the same as before, but for the opposite side of the Y axis.
        {
            transform.position = new Vector3(0, 4.8f, 0); //Blah blah, sends it around
        }
        if (transform.position.x >= 10.3) //This checks the same as before, but on the X axis.
        {
            transform.position = new Vector3(-8.5f, 0, 0); //sends it around.
        }
        if (transform.position.x <= -8.8) //Same for the opposite of the X axis
        {
            transform.position = new Vector3(10.3f, 0, 0); //Sends around.
        }
    }

    void Spawn()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-7.5f, 9), UnityEngine.Random.Range(-4.69f, 5.2f), 0); //randomises the spawn point based on the lenght and base.
    }

    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        Warps();
    }
}
