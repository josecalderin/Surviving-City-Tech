using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.transform.tag == "Player")
            {
                SceneManager.LoadScene("Boss Fight");
               
        }
            if (StepCounter.stepCount < 200)
            {
            
            SceneManager.LoadScene("You Lose");
                
        }
        }
    
}
