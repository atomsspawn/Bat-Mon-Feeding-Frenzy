using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyScript : MonoBehaviour
{
    public GameObject player;
    private Transform playerPos;
    private Vector2 currentPos;
    public float distance;
    public float speedEnemy;
    private Animator enemyAnim;
    

    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
        enemyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            if (enemyAnim.transform.position.x < player.transform.position.x)
            {
                transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.deltaTime);
                transform.eulerAngles = (new Vector3(0, 180, 0));
                enemyAnim.SetBool("Patrol", true);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.deltaTime);
                enemyAnim.SetBool("Patrol", true);
            }
        if(Vector2.Distance(transform.position, playerPos.position) < 8)
            {
                transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.deltaTime);
                enemyAnim.SetBool("Dask", true);
            }
            if(Vector2.Distance(transform.position, playerPos.position) < 5)
            {
                transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.deltaTime);
                enemyAnim.SetBool("Attack", true);
            }
        }
        else
        {
            if(Vector2.Distance(transform.position, currentPos) <= 0)
            {
                enemyAnim.SetBool("Patrol", false);
                
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currentPos, speedEnemy * Time.deltaTime);
                enemyAnim.SetBool("Patrol", true);
                
            }
        }
    }
}
