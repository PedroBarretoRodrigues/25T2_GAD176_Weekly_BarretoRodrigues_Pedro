using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // We want to rotate when we hold Q and E
    [SerializeField] private float rotationDegreesPerSecond = 1;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            // Rotate Left
            transform.Rotate(0, -rotationDegreesPerSecond, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            // Rotate Right
            transform.Rotate(0, rotationDegreesPerSecond, 0);
        }
    }


}
