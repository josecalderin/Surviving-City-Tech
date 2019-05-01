using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepCounter : MonoBehaviour
{
    public static int stepCount = 400;
    Text steps;

    void Start()
    {
        steps = GetComponent<Text>();
    }

    void Update()
    {
        steps.text = "GPA: " + stepCount;
    }
}
