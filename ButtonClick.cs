using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Image Recticle;
    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RayCasting();
    }

    void RayCasting()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward * 1000);

        if(Physics.Raycast(transform.position, forward, out hit))
        {
            Debug.Log("hit!");
            buttonSelect(hit);
        }
        else
        {
            timeElapsed = timeElapsed - Time.deltaTime;
            Recticle.fillAmount = timeElapsed / 3;
            if (timeElapsed <= 0)
            {
                timeElapsed = 0;
            }
        }
        Debug.DrawRay(transform.position, forward, Color.red);
    }

   void buttonSelect(RaycastHit hit)
    {
        if(hit.transform.tag == "UI")
        {
            timeElapsed = timeElapsed + Time.deltaTime;
            Recticle.fillAmount = timeElapsed / 3;
            if(timeElapsed >= 3)
            {
                timeElapsed = 3;
                hit.transform.GetComponent<Button>().onClick.Invoke();
                Debug.Log("button invoke!");
            }
        }
        else
        {
            timeElapsed = timeElapsed - Time.deltaTime;
            Recticle.fillAmount = timeElapsed / 3;
            if (timeElapsed <= 0)
            {
                timeElapsed = 0;
            }
        }
    }
}