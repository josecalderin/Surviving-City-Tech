﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepCounter : MonoBehaviour
{
    public static int stepCount = 400;
    Text steps;

    void Start()
    {
        //stepCount = PlayerPrefs.GetInt("Player GPA");
        steps = GetComponent<Text>();
        //DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
        steps.text = "GPA: " + stepCount;
        //PlayerPrefs.SetInt("Player GPA", stepCount);
        
    }
}
