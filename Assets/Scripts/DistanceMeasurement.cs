using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DistanceMeasurement : MonoBehaviour
{
    public Transform object1; // Reference to the first object
    public Transform object2; // Reference to the second object
    public TextMeshProUGUI distanceText; // Reference to the TextMeshPro text component

    void Update()
    {
        // Calculate the distance between object1 and object2
        float distance = Vector3.Distance(object1.position, object2.position);
        float finaldistance = distance - 0.417f;

        // Update the text to display the distance
        distanceText.text = "" + finaldistance.ToString("F3"); // Displaying distance up to 2 decimal places
    }
}
