using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ijkl : MonoBehaviour
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
        if (Input.GetKey(KeyCode.I))
        {
            //Debug.Log("I move right");
            newPosition.y += speed;
            if (newPosition.y > 4.5f)
            {
                newPosition.y = 4.5f;
            }
        }

        if (Input.GetKey(KeyCode.J))
        {
            //Debug.Log("I move right");
            newPosition.x -= speed;
            if (newPosition.x < 0.5f)
            {
                newPosition.x = 0.5f;
            }
        }

        if (Input.GetKey(KeyCode.K))
        {
            //Debug.Log("I move right");
            newPosition.y -= speed;
            if (newPosition.y < -4.5f)
            {
                newPosition.y = -4.5f;
            }
        }

        if (Input.GetKey(KeyCode.L))
        {
            //Debug.Log("I move right");
            newPosition.x += speed;
            if (newPosition.x > 8f)
            {
                newPosition.x = 8f;
            }

        }

        transform.position = newPosition;
    }
}
