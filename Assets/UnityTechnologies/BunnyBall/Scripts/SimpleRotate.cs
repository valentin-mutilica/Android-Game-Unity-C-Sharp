using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public Vector3 speed;

    void Update()
    {
        transform.Rotate(speed * Time.deltaTime);    
    }
}
