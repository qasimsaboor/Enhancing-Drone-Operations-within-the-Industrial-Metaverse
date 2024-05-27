using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
public class BulbEvent : MonoBehaviour
{
    public TextMeshProUGUI[] counterTexts = new TextMeshProUGUI[6];
    private int[] counters = new int[6];
    private int currentTriggerIndex = 0;

    // Function to increase the counter and display it in the current counterText
    public void IncreaseCounter()
    {
        counters[currentTriggerIndex]++;
        counterTexts[currentTriggerIndex].text = "ED " + (currentTriggerIndex + 1) + ": " + counters[currentTriggerIndex].ToString();
    }

    // Function to be called when entering the finish line trigger
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finishline"))
        {
            // Save the counter value
            int previousIndex = currentTriggerIndex;

            // Move to the next trigger index
            currentTriggerIndex++;

            // If we reach the end, loop back to the beginning
            if (currentTriggerIndex >= counterTexts.Length)
            {
                currentTriggerIndex = 0;
            }

            // Reset the next counter
            counters[currentTriggerIndex] = 0;

            // Update the text for the next counter
            counterTexts[currentTriggerIndex].text = "ED " + (currentTriggerIndex + 1) + ": " + counters[currentTriggerIndex].ToString();

            // Update the text for the previous counter
            counterTexts[previousIndex].text = "ED " + (previousIndex + 1) + ": " + counters[previousIndex].ToString();
        }
    }
}
