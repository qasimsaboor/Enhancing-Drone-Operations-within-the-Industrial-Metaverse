using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    public GameObject box; // Reference to the box GameObject
    public GameObject box1;
    public GameObject box2;
    public AudioSource source;

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the one you want
        if (other.CompareTag("Drop"))
        {
            // Detach the box from the drone
            box.transform.parent = null;

            // Add a Rigidbody to the box to make it fall
            Rigidbody boxRb = box.AddComponent<Rigidbody>();
            //boxRb.useGravity = true;

            // Optional: You can add additional physics settings to the boxRb if needed
            // boxRb.mass = 1f;
            // boxRb.drag = 0.5f;

            // Disable collision between the box and the drone
            Physics.IgnoreCollision(box.GetComponent<Collider>(), GetComponent<Collider>());
            source.Play();
            // Optionally, you can destroy or disable this script to prevent OnTriggerEnter from being called again
            // Destroy(this);
            // enabled = false;
        }
        else if (other.CompareTag("Drop1"))
        {
            // Detach the box from the drone
            box1.transform.parent = null;

            // Add a Rigidbody to the box to make it fall
            Rigidbody boxRb1 = box1.AddComponent<Rigidbody>();
            //boxRb.useGravity = true;

            // Optional: You can add additional physics settings to the boxRb if needed
            // boxRb.mass = 1f;
            // boxRb.drag = 0.5f;

            // Disable collision between the box and the drone
            Physics.IgnoreCollision(box1.GetComponent<Collider>(), GetComponent<Collider>());
            source.Play();
            // Optionally, you can destroy or disable this script to prevent OnTriggerEnter from being called again
            // Destroy(this);
            // enabled = false;
        }
        else if (other.CompareTag("Drop2"))
        {
            // Detach the box from the drone
            box2.transform.parent = null;

            // Add a Rigidbody to the box to make it fall
            Rigidbody boxRb1 = box2.AddComponent<Rigidbody>();
            //boxRb.useGravity = true;

            // Optional: You can add additional physics settings to the boxRb if needed
            // boxRb.mass = 1f;
            // boxRb.drag = 0.5f;

            // Disable collision between the box and the drone
            Physics.IgnoreCollision(box2.GetComponent<Collider>(), GetComponent<Collider>());
            source.Play();
            // Optionally, you can destroy or disable this script to prevent OnTriggerEnter from being called again
            // Destroy(this);
            // enabled = false;
        }
    }
}