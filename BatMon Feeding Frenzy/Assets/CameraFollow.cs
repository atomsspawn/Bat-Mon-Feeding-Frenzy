using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //The Target
    public Transform target;

    // Update is called once per frame
    void LateUpdate()
    {
        if(target == null) return;
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}
