using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    public GameObject light;

    public void TurningOff()
    {
        light.SetActive(false);
    }
}
