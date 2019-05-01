using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    private bool dirRight = true;
    public float speed;

    void Update()
    {
        move();
    }
    void move()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 1.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -1)
        {
            dirRight = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Player"));
        }
    }
}
