using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosscredit : MonoBehaviour
{
    public static int Credit;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
        Credit = PlayerPrefs.GetInt("Player GPA", HudText.scoreValue);
    }

    void Update()
    {
        score.text = "Credits: " + Credit;
        PlayerPrefs.SetInt("Player GPA", Credit);

    }
}
