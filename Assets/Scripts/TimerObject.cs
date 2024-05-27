using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerObject : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Reference to the UI text element where you want to display the timer
    private bool timerStarted = false;
    private float elapsedTime = 0f;
    private int milliseconds = 0;
    public GameObject oldfinishline;
    public GameObject newfinishline;
    private int counter = 0;

    public float ElapsedTime => elapsedTime;

    void Update()
    {
        if (timerStarted)
        {
            elapsedTime += Time.deltaTime;
            milliseconds = Mathf.FloorToInt((elapsedTime - Mathf.Floor(elapsedTime)) * 1000);
            UpdateTimerUI();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            StartTimer();
            newfinishline.SetActive(true);
            oldfinishline.SetActive(false);
        }
    }

    void StartTimer()
    {
        timerStarted = true;
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        timerText.text = string.Format("" + "{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    // Stop the timer and return the elapsed time
    public float StopTimer()
    {
        timerStarted = false;
        return elapsedTime;
    }
}