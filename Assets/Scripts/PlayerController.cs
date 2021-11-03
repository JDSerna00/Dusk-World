using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    Vector3 initPosition;
    public int maxHealth = 1;
    public int health = 1;
    public int currentHealth;
    public TextMeshProUGUI countMonedasText;
    private int count;

    private float moveX;
   
    void Awake()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        initPosition = this.transform.position;
        count = 0;

        SetCountMonedasText();
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

    public void SetCountMonedasText()
    {
       countMonedasText.text = "" + count.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.CompareTag("Monedas"))
       {
           count = count + 1;

           SetCountMonedasText();
       }
    }   
}
