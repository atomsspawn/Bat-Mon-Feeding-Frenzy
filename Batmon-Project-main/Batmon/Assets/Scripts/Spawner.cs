using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject[] Collectibles;
    public float height;
    public float timetolive = 5;
    public GameObject topboundary;
    public GameObject botboundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime && Collectibles.Length > 0)
        {
            GameObject newCollectible = Instantiate(Collectibles[Random.Range(0, Collectibles.Length)]);
            float topy= topboundary.transform.position.y;
            float boty= botboundary.transform.position.y;
            if(height > topy)
            {
                height = topy;
            }
            else if (height < boty)
            {
                height = boty;
            }
            newCollectible.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);

            Destroy(newCollectible, timetolive);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}