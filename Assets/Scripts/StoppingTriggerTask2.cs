using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoppingTriggerTask2 : MonoBehaviour
{
    public TimerObject timerObject;
    public GameObject drone;
    public GameObject targetObject;
    public GameObject OldStartLine;
    public GameObject NewStartLine;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            // Access the TimerObject script and stop the timer
            float elapsedTime = timerObject.StopTimer();
            drone.transform.position = targetObject.transform.position;
            OldStartLine.SetActive(false);
            NewStartLine.SetActive(true);
                      
   
        }
    }
}