using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_controller : MonoBehaviour
{

    public void Sun_control1()
    {
        RenderSettings.ambientIntensity = 0.3f;
        this.transform.localEulerAngles = new Vector3(15, -15, -75);
    }

    public void Sun_control2()
    {
        RenderSettings.ambientIntensity = 1.1f;


        this.transform.localEulerAngles = new Vector3(160, 90, 210);


    }

    public void Sun_control3()
    {
        RenderSettings.ambientIntensity = 0.5f;
        this.transform.localEulerAngles = new Vector3(160, 55, 55);
    }
}
