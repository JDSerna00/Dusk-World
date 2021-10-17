using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    Vector3 initPosition;
    public int maxHealth = 1;
    public int health = 1;
    public int currentHealth;

    private float moveX;
   
    void Awake()
    {
        currentHealth = maxHealth;
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
    public void ChangeHealth(int amount)
    {
        if (health > 0)
        {
            health -= amount;
        }

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
