using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{

    public float moveSpeed = 2f; //moveSpeed variable.
    private float turnSpeed = 45f; //Turn/rotaion speed variable.
    private float leftTurnSpeed = 22.5f; //I could do (turnSpeed / 2), or just separate the different sides from the beginning.

    void RandomSpeed()
    {
        moveSpeed = moveSpeed + (UnityEngine.Random.Range(-10, 10));
    }

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
        transform.Translate(0, moveSpeed * Time.deltaTime, 0); //Keeps the ship moving.

        if (Input.GetKey(KeyCode.S)) //Buttonpress to slow down.
        {
            transform.Translate(0, (-moveSpeed / 2) * Time.deltaTime, 0); //Since the movement is constant, I just have to divide the speed by half (or by a third, or a fourth, etc etc.).
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(0, (moveSpeed * 5) * Time.deltaTime, 0);
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
