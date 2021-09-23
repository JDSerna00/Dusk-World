using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float JumpForce = 10f;
    public Rigidbody2D rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            if (collision.gameObject.GetComponent<Rigidbody2D>())
            {
              if (rb != null)
              {
                Vector2 velocity = rb.velocity;
                velocity.y = JumpForce;
                rb.velocity = velocity;
              }
            }  
        }   
    }
}
