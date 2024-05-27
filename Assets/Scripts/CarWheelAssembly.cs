using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWheelAssembly : MonoBehaviour
{
    public GameObject Tightener;
    public GameObject TightenerNew;
    public Animator Cars;
    public Animator wheelanim;
    public Animator openstation;
    public GameObject Wheel1;
    public GameObject Wheel2;
    public GameObject Wheel3;
    public GameObject Wheel4;
    public GameObject Wheel5;
    public GameObject Wheel6;
    public GameObject Wheel7;
    public GameObject Wheel8;
    // Start is called before the first frame update
    void Start()
    {
        wheelanim.GetComponent<Animator>();
    }
    void CarMovements()
    {
        Cars.Play("Cars");
    }
    void TightOn()
    {
        Tightener.SetActive(false);
        TightenerNew.SetActive(true);
    }
    void TightOff()
    {
        Tightener.SetActive(true);
        TightenerNew.SetActive(false);
    }
    void ConveyerMovement()
    {
        wheelanim.Play("Wheelsconveyer");
    }
    void StationOpen()
    {
        openstation.Play("CarRobotOpener");
    }
   
    void p1()
    {
        Wheel1.SetActive(false);
    }
    void p2()
    {
        Wheel2.SetActive(false);
    }
    void p3()
    {
        Wheel3.SetActive(false);
    }
    void p4()
    {
        Wheel4.SetActive(false);
    }
    void p5()
    {
        Wheel5.SetActive(false);

    }
    void p6()
    {
        Wheel6.SetActive(false);

    }
    void p7()
    {
        Wheel7.SetActive(false);

    }
    void p8()
    {
        Wheel8.SetActive(false);

    }
}
