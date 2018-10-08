using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{

    private float moveSpeed = 1f; //moveSpeed variable.
    private float turnSpeed = 45f; //Turn/rotaion speed variable.
    private float leftTurnSpeed = 22.5f;
    


    void movement()
    {



        if (Input.GetKey(KeyCode.D)) //Buttonpress for right rotation.
        {

            transform.Rotate(new Vector3(0, 0, -turnSpeed) * Time.deltaTime); //Makes the vehicle turn/rotate.
        }
        if (Input.GetKey(KeyCode.A)) //Buttonpress for left rotation.

        {
            transform.Rotate(new Vector3(0, 0, leftTurnSpeed) * Time.deltaTime); //Makes the vehicle turn, this time the rotation isn't in the negative, so as to turn the opposite direction.
        }

        transform.Translate(0, 1 * Time.deltaTime, 0); //Keeps the ship moving/

        if (Input.GetKey(KeyCode.S)) //Buttonpress to slow down.
        {
            transform.Translate(0, -0.5f * Time.deltaTime, 0); //Since the movement is constant, I just have to subtract half of the speed.
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement();
        
    }
}
