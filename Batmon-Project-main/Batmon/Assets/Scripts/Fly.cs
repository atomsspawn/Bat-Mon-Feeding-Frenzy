using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public double energyCost = -0.5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;
            gameManager.setPoints(energyCost);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Collectible")
        {
            CollectItem itemInfo = collision.gameObject.GetComponent<CollectItem>();
            gameManager.setPoints(itemInfo.GetPoints());
        }
        else if (collision.gameObject.tag == "Boundary")
        {
            gameManager.setGameState("Game Over");
        }
        else
        {
            Debug.Log("Collsion unhandled at: " + collision.gameObject.name + " With tag: " + collision.gameObject.tag );
        }
    }
}
