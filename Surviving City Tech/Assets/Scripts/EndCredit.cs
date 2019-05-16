using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCredit : MonoBehaviour
{
    public static int Endcredit;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
        Endcredit = PlayerPrefs.GetInt("Player GPA", bosscredit.Credit);
    }

    void Update()
    {
        score.text = "Credits: " + Endcredit;
        
    }
}
