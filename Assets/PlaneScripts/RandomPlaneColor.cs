using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlaneColor : MonoBehaviour
{

    public SpriteRenderer RandomColor;

    void randomColor()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           RandomColor.color = new Color(UnityEngine.Random.Range(0.1f, 1), UnityEngine.Random.Range(0.1f, 1), UnityEngine.Random.Range(0.1f, 1));
        }

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        randomColor();
    }
}
