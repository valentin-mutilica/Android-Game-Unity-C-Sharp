using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snack : MonoBehaviour
{

    public float rotateSpeed;
    

    private void FixedUpdate()
    {
        //Angle, center, scale
        transform.Rotate(2, rotateSpeed, -2);
    }
}

