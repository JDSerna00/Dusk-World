using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
  public GameObject player;
  public GameObject platformPrefab;
  public GameObject platform2Prefab;
    

  void Start()
  {
        
  }

  
  void Update()
  {
        
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    Destroy (GameObject.FindWithTag("Platforms"), 10f );
    Destroy (GameObject.FindWithTag("Platforms2"), 13f );
    Destroy (GameObject.FindWithTag("Platforms3"), 15f );
    Destroy (GameObject.FindWithTag("Platforms4"), 17f );
    Destroy (GameObject.FindWithTag("PlatformsEnemigo1"), 12f );
    Destroy (GameObject.FindWithTag("PlatformsEnemigo2"), 15f );
  }
}
