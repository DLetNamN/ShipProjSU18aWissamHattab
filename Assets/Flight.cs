using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{

    public float moveSpeed = 1;
    public float turnSpeed = 45f;
    private SpriteRenderer PlaneSprite;
    private Color planeColor;


    void movement()
    {



        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(new Vector3(0, 0, -turnSpeed) * Time.deltaTime);
            PlaneSprite.color = new Color(0f, 0f, 10f);

        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(0, 0, turnSpeed * Time.deltaTime);

        }
        transform.Translate(0, 1f * Time.deltaTime, 0);
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
