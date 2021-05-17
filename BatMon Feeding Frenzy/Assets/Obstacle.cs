using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Movement Speed (O is stopped)
    public float speed = 0;

    //Swith Movement Direction every x seconds
    public float switchTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        //Initial Movement Direction
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        //Switch every few seconds
        InvokeRepeating("Switch", 0, switchTime);
    }

    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
