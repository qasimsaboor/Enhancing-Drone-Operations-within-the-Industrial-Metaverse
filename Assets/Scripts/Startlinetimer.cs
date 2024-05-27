using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Startlinetimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer;
    private bool isTiming;

    private void Start()
    {
        timer = 0f;
        isTiming = false;
    }

    private void Update()
    {
        if (isTiming)
        {
            timer += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            StartTimer();
        }
    }

    private void StartTimer()
    {
        isTiming = true;
    }
    public void StopTimer()
    {
        isTiming = false;
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        int milliseconds = Mathf.FloorToInt((timer * 1000) % 1000);
        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}