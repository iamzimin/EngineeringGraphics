using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public AxonometricRectangularDimetricProjection first;
    public AxonometricRectangularIsometricProjection second;
    public AxonometricObliqueFrontalIsometricProjection third;
    public AxonometricObliqueHorizontalIsometricProjection fourth;

    void Start()
    {
        first.enabled = true;
        second.enabled = false;
        third.enabled = false;
        fourth.enabled = false;
    }

    public void buttonClick(int id)
    {
        Camera.main.transform.position = new Vector3(0, 0, -100);
        Camera.main.transform.rotation = new Quaternion(0, 0, 0, 0);
        if (id == 0)
        {
            first.enabled = true;
            second.enabled = false;
            third.enabled = false;
            fourth.enabled = false;
        }
        else if (id == 1)
        {
            first.enabled = false;
            second.enabled = true;
            third.enabled = false;
            fourth.enabled = false;
        }
        else if (id == 2)
        {
            first.enabled = false;
            second.enabled = false;
            third.enabled = true;
            fourth.enabled = false;
        }
        else if (id == 3)
        {
            first.enabled = false;
            second.enabled = false;
            third.enabled = false;
            fourth.enabled = true;
        }
    }

}
