using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneColor : MonoBehaviour
{

    public SpriteRenderer PlaneSprite;


    void ColorChanger()
    {
        if (Input.GetKey(KeyCode.D))
        {
            PlaneSprite.color = new Color(0f, 0f, 1f); //This is to change the color of the PlaneSprite. I made this a separate script to add it onto each part of the plane, so as to not affect it by the other parts of the script.
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlaneSprite.color = new Color(0f, 1f, 0f);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ColorChanger();
    }
}
