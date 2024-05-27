using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator Rim;
    public Animator Table;
    public Animator Opener;
    public Animator Tester;
    public Animator Robot2;
    public GameObject head;
    public GameObject newhead;
    public GameObject r1;
    public GameObject r2;
    public GameObject r3;
    public GameObject r4;
    public GameObject k;
    public GameObject k1;
    public GameObject Rubber1;
    public GameObject Rubber2;
    public GameObject Rubber3;
    public GameObject Rubber4;
    public GameObject Rim1;
    public GameObject Rim2;
    public GameObject Rim3;
    public GameObject Rim4;
    public GameObject TestWheel;
    public GameObject Wheel;
    // Start is called before the first frame update
    void Start()
    {
        Rim.GetComponent<Animator>();
        Table.GetComponent<Animator>();
        Robot2.GetComponent<Animator>();
    }

    void RotateRim()
    {
        Rim.Play("RimRotation");
    }
    void RotateTable()
    {
        Table.Play("TableRot");
    }
    void RotateTableQuater()
    {
        Table.Play("TableQuaterRotate");
    }
    void RotateWheelTest()
    {
        Table.Play("WheelRotator");
    }
    void Openstation()
    {
        Opener.Play("Opener");
    }
    void Robot2Activated()
    {
        Robot2.Play("Robot2Rot");
    }
    void OppositeRobotActivated()
    {
        Robot2.Play("OppositeRobot2");
    }
    void TesterRotator()
    {
        Tester.Play("TestingRotate");
    }
    void Switcher()
    {
        head.SetActive(false);
        newhead.SetActive(true);
    }
    void ReverseSwitcher()
    {
        head.SetActive(true);
        newhead.SetActive(false);
    }
    void p1()
    {
        r1.SetActive(false);
        k.SetActive(true);
    }
    void p2()
    {
        r2.SetActive(false);
        k.SetActive(true);
    }
    void p3()
    {
        r3.SetActive(false);
        k.SetActive(true);
    }
    void p4()
    {
        r4.SetActive(false);
        k.SetActive(true);
    }
    void d1()
    {
        k.SetActive(false);
        Rubber1.SetActive(true);
    }
    void d2()
    {
        k.SetActive(false);
        Rubber2.SetActive(true);
    }

    void d3()
    {
        k.SetActive(false);
        Rubber3.SetActive(true);
    }

    void d4()
    {
        k.SetActive(false);
        Rubber4.SetActive(true);
    }
    void Wheel1pick()
    {
        k1.SetActive(true);
        k.SetActive(true);
        Rim1.SetActive(false);
    }
    void Wheel2pick()
    {
        k1.SetActive(true);
        k.SetActive(true);
        Rim2.SetActive(false);
    }
    void Wheel3pick()
    {
        k1.SetActive(true);
        k.SetActive(true);
        Rim3.SetActive(false);
    }
    void Wheel4pick()
    {
        k1.SetActive(true);
        k.SetActive(true);
        Rim4.SetActive(false);
    }
    void Wheeldrop()
    {
        k.SetActive(false);
        TestWheel.SetActive(true);
    }

    void WheelTestPick()
    {
        k.SetActive(true);
        TestWheel.SetActive(false);
    }

    void FinalWheel()
    {
        k.SetActive(false);
        Wheel.SetActive(true);
    }



}
