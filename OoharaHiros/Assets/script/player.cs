using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class player : MonoBehaviour
{
    private float speed = 0.005f;

    void Start()
    {
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("a"))
        {
            position.x -= speed;
        }
        if (Input.GetKey("d"))
        {
            position.x += speed;
        }
        if (Input.GetKey("w"))
        {
            position.y += speed;
        }
        if (Input.GetKey("s"))
        {
            position.y -= speed;
        }
        transform.position = position;


    }
}