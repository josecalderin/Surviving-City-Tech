using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    private float bossHP = 100;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnParticleCollision(GameObject other)
    {

        if (other.tag == "att")
        {
            bossHP -= GameFlow.currentDamage;
            Debug.Log(bossHP);
        }

    }
}
