using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{

    public float moveSpeed = 1f;
    public float turnSpeed = 45f;



    void movement()
    {



        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(new Vector3(0, 0, -turnSpeed) * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(0, 0, turnSpeed * Time.deltaTime);

        }

        transform.Translate(0, 1 * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.5f * Time.deltaTime, 0);
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
