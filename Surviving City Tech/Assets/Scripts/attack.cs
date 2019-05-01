using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Transform rangeattack;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        var posX = gameObject.transform.position.x;
        var posY = gameObject.transform.position.y;
        if (Input.GetKeyDown("1") && HudText.scoreValue >= 1)
        {
            GetComponent<Transform>().position = new Vector2(posX, posY);
            Instantiate(rangeattack, new Vector2((posX+1.0f), (posY-.25f)), rangeattack.rotation);
            HudText.scoreValue -= 1;
        }
    }
}
