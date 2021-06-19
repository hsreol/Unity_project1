using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_control : MonoBehaviour
{

    public float time_x = 0;

    public void Sun_control1()
    {
        Debug.Log("ITS ME");
    }

    public void Sun_control2()
    {

        if (time_x <= 90)
        {
            time_x += Time.deltaTime;
            this.transform.localEulerAngles = new Vector3(time_x, 0, 0);
        }

    }

    public void Sun_control3()
    {
        if (time_x <= 180)
        {
            time_x += Time.deltaTime;
            this.transform.localEulerAngles = new Vector3(time_x, 0, 0);
        }
    }
}
