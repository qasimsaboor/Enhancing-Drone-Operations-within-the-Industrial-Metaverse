using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject droneBox;
    public GameObject pickupBox;
    public AudioSource source;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            pickupBox.SetActive(false);
            droneBox.SetActive(true);
            source.Play();


        }
    }
}
