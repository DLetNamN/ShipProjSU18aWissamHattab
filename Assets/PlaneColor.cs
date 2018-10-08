using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneColor : MonoBehaviour
{

    public SpriteRenderer PlaneSprite;
    public Color planeColor;

    void ColorChanger()
    {
        if (Input.GetKey(KeyCode.D))
        {
            PlaneSprite.color = new Color(0f, 0f, 1f);
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
