using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class itemtimer : MonoBehaviour
{
    public Startlinetimer timerStartScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            timerStartScript.StopTimer();
        }
    }
}

