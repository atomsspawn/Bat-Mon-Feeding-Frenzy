using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bat : MonoBehaviour
{
    public AudioSource BatWing;

    //Movement speed
    public float speed = 2;

    //Flap force
    public float force = 300;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        //Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //Flap
        if (Input.GetKeyDown(KeyCode.Space)) { 
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        BatWing.Play();
            }

    }

    //Called when a collision occurs
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        //Restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnLevelWasLoaded(int level)
    {
        FindStartPos();
    }

    void FindStartPos()
    {
        transform.position = GameObject.FindWithTag("StartPos").transform.position;
    }
}
