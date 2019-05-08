using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScoreCounter : MonoBehaviour
{

    public static int HiScoreValue = 1;
    Text hiScore;
    // Start is called before the first frame update
    void Start()
    {
        hiScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hiScore.text = "Hi-Score: " + (EndCredit.Endcredit + 1) * BossCounterStatic.myGPA;
    }
}
