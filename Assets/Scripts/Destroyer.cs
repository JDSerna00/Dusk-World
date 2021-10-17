using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      Destroy (GameObject.FindWithTag("Platforms"), 0.5f );
    }
}
