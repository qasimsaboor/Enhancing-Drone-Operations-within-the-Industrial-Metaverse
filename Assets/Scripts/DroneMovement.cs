using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float downLimitY = 3f; // Y-coordinate limit for downward movement
    public float upLimitY = 17f;

    public void MoveForward()
    {
        if (CanMoveUpDown())
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
    }

    public void MoveBackward()
    {
        if (CanMoveUpDown())
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }
    }

    public void MoveDown()
    {
        // Check if the drone's current position is above the down limit
        if (transform.position.y > downLimitY)
        {
            // Move the drone downwards
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }
    }

    public void MoveUp()
    {
        // Check if the drone's current position is below the up limit
        if (transform.position.y < upLimitY)
        {
            // Move the drone upwards
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
    }

    // Function to check if the drone is within the up and down limits
    private bool CanMoveUpDown()
    {
        return transform.position.y >= upLimitY;
    }
}
