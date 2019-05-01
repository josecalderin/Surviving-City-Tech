using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpforce;
    public float speed;
    public bool isGrounded;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
        jumpspace();
    }
    void jumpspace()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGrounded)
        {
            isGrounded = true;
            rb.AddForce(new Vector2(rb.velocity.x, jumpforce));

        }
      
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
            Debug.Log("im touching ground");
           // rb.velocity = Vector2;
        }
    }

 
}

