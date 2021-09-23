using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < 271.2f)
        {
            transform.position = StartPosition;
        }
    }
}
