using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
public class StoreDataTask2 : MonoBehaviour
{
    public TextMeshProUGUI[] textMeshPros = new TextMeshProUGUI[12];
    private string filePath;

    void Start()
    {
        // Set the file path for saving the CSV file
        string folderPath = "C:/Users/play/Desktop/Qasim Saboor/Master Thesis/Assets/CSV files";
        string fileName = "dataTask2_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".csv"; ;
        filePath = Path.Combine(folderPath, fileName);
    }

    // Function to save the data to a CSV file
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write header
                writer.Write("Task2Assembly1Trial1Timer,");
                writer.Write("Task2Assembly2Trial2Timer,");
                writer.Write("Task2Assembly3Trial3Timer,");      
                writer.Write("Task2Assembly1DistancetoTargetTrial1,");
                writer.Write("Task2Assembly2DistancetoTargetTrial2,");
                writer.Write("Task2Assembly3DistancetoTargetTrial3,");
                writer.Write("Task2Assembly1DistancetillPickupTrial1,");
                writer.Write("Task2Assembly1DistancetillDropOffTrial1,");
                writer.Write("Task2Assembly1DistancetillPickupTrial2,");
                writer.Write("Task2Assembly1DistancetillDropOffTrial2,");
                writer.Write("Task2Assembly1DistancetillPickupTrial3,");
                writer.Write("Task2Assembly1DistancetillDropOffTrial3,");



                // Write data for each TextMeshPro object
                for (int i = 0; i < textMeshPros.Length; i++)
                {
                    writer.Write(textMeshPros[i].text + ",");
                }
            }

            Debug.Log("Data saved to CSV file: " + filePath);
        }
    }

}