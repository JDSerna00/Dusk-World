using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    Vector3 initPosition;

    private float moveX;
   
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        initPosition = this.transform.position;
    }

    void Update()
    {
       moveX = Input.GetAxis("Horizontal") *  moveSpeed;
    }

    private void FixedUpdate()
    {
       Vector2 velocity = rb.velocity;
       velocity.x = moveX;
       rb.velocity = velocity;
    }
    public void ResetPosition()
    {
        this.transform.position = initPosition;
    }
}
