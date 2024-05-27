using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot2AnimationTrigger : MonoBehaviour
{
    public Animator FinalWheel;
    public GameObject FinalWheelObj;
    public GameObject Wheel1;
    public GameObject Wheel2;
    public GameObject Wheel3;
    public GameObject Wheel4;
    // Start is called before the first frame update
    void Start()
    {
        FinalWheel.GetComponent<Animator>();
    }

    void RotateWheel()
    {
        FinalWheel.Play("FinalWheel");
    }
    void FinalWheelOff()
    {
        FinalWheelObj.SetActive(false);
    }

    void Wheel1On()
    {
        Wheel1.SetActive(true);
    }
    void Wheel2On()
    {
        Wheel2.SetActive(true);
    }
    void Wheel3On()
    {
        Wheel3.SetActive(true);
    }
    void Wheel4On()
    {
        Wheel4.SetActive(true);
    }
}
