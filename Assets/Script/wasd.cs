using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        //只在第一帧执行
        //Debug.Log("Hi");
    }

    // Update is called once per frame
    void Update()
    {
        //每一帧都会执行
        //Debug.Log("Over and over ...");

        Vector3 newPosition = transform.position;

        //持续输入D，输出debug.log
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("I move right");
            newPosition.y += speed;
            if (newPosition.y > 4.5f)
            {
                newPosition.y = 4.5f;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("I move right");
            newPosition.x -= speed;
            if (newPosition.x < -8f)
            {
                newPosition.x = -8f;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("I move right");
            newPosition.y -= speed;
            if (newPosition.y < -4.5f)
            {
                newPosition.y = -4.5f;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("I move right");
            newPosition.x += speed;
            if (newPosition.x > -2)
            {
                newPosition.x = -2;
            }
        }

        if (newPosition.x > 4)
        {
            newPosition.x = -4.5f;
        }

        transform.position = newPosition;
    }
}