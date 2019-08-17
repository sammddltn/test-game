using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    //public float ClickDuration = 1;


    bool clicking = false;
    float totalDownTime = 0;

    public Slider slider;


    // Update is called once per frame
    void Update()
    {
        // Detect the first click
        if (Input.GetMouseButtonDown(0))
        {
            totalDownTime = 0;
            clicking = true;
        }

        if (clicking && Input.GetMouseButton(0))
        {
            totalDownTime += Time.deltaTime;
            if (totalDownTime > 1)
            {
                totalDownTime = 1;
            }
            slider.value = (totalDownTime);

        }

        if (clicking && !Input.GetMouseButton(0))
        {
            clicking = false;
        }
        if (slider.value > .01)
        {
            slider.value = (slider.value * 0.9f);
        }
        else
        {
            slider.value = 0;
        }
    }
}