using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2;
    public bool isActive;
    public GameObject spawnPoint;


    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        if (newPosition.x > 8)
        {
            newPosition.x = -8;
        }
        transform.position = newPosition;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = collision.gameObject;

            player.transform.position = spawnPoint.transform.position;
            //Destroy(player);
            GameManager.instance.lives_red -= 1;
            Debug.Log("hit player");
        }

        if (collision.gameObject.tag == "player1")
        {
            GameObject player = collision.gameObject;

            player.transform.position = spawnPoint.transform.position;
            //Destroy(player);
            GameManager.instance.lives_blue -= 1;
            Debug.Log("hit player blue");
        }
    }

}
