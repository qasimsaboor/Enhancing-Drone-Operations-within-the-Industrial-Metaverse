using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StoppingTrigger : MonoBehaviour
{
    public TimerObject timerObject;
    public GameObject drone;
    public GameObject targetObject;
    public GameObject OldStartLine;
    public GameObject NewStartLine;
    public GameObject Red;
    public GameObject Green;
    public GameObject Red1;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            // Access the TimerObject script and stop the timer
            float elapsedTime = timerObject.StopTimer();
            drone.transform.position = targetObject.transform.position;
            OldStartLine.SetActive(false);
            NewStartLine.SetActive(true);
            Red.SetActive(false);
            Green.SetActive(true);
            Red1.SetActive(true);
            // You can now use 'elapsedTime' as the time value and perform any additional actions
        
        }
    }
}