using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    // Speed multiplier for movement
    public float speed = 10.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;

        // We assume that the device is held parallel to the ground
        // and the home button is facing down in portrait orientation

        // Remap device acceleration axis to game coordinates:
        // 1) XY plane of the device is mapped onto XZ plane
        // 2) Rotated 90 degrees around X axis to account for portrait orientation
        dir.x = Input.acceleration.x;
        dir.z = Input.acceleration.y;

        // Clamp acceleration vector to unit sphere
        if (dir.magnitude > 1)
        {
            dir.Normalize();
        }

        // Scale direction vector by time and speed
        dir *= Time.deltaTime * speed;

        // Move object in the direction of the vector
        transform.Translate(dir);
    }
}
