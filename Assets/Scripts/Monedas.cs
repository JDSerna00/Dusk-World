using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
       
       PlayerController controller = other.GetComponent<PlayerController>();

       Destroy(gameObject);
        
        
    }
}
