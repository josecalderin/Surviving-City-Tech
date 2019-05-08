using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCounterStatic : MonoBehaviour
{
    public static int myGPA;
    Text steps;
    

    void Start()
    {
        //myoldGPA = GameObject.Find("persistentObject");
        //int stepCount = myoldGPA.GetComponent<StepCounter>().stepCount;
        steps = GetComponent<Text>();
        myGPA = PlayerPrefs.GetInt("Player GPA", StepCounter.stepCount);
    }

    void Update()
    {
        steps.text = "GPA: " + myGPA;
        
    }
}
