using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ErrorDetector : MonoBehaviour
{
    public void SetMeOff()
    {
        this.gameObject.SetActive(false);
    }
}
