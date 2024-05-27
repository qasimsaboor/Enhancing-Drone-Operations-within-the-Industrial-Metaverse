using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
public class StoreData : MonoBehaviour
{
    public TextMeshProUGUI[] textMeshPros = new TextMeshProUGUI[12];
    private string filePath;

    void Start()
    {
        // Set the file path for saving the CSV file
        string folderPath = "C:/Users/play/Desktop/Qasim Saboor/Master Thesis/Assets/CSV files";
        string fileName = "dataTask1_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".csv"; ;
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
                writer.Write("Task1Assembly1Trial1Timer,");
                writer.Write("Task1Assembly1Trial2Timer,");
                writer.Write("Task1Assembly1Trial3Timer,");
                writer.Write("Task1Assembly2Trial1Timer,");
                writer.Write("Task1Assembly2Trial2Timer,");
                writer.Write("Task1Assembly2Trial3Timer,");
                writer.Write("Task1Assembly1EDTrial1,");
                writer.Write("Task1Assembly1EDTrial2,");
                writer.Write("Task1Assembly1EDTrial3,");
                writer.Write("Task1Assembly2EDTrial1,");
                writer.Write("Task1Assembly2EDTrial2,");
                writer.Write("Task1Assembly2EDTrial3,");


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
