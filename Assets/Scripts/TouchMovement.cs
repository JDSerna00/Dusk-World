using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float screenHalf = Screen.width / 2;
            Vector3 movement = Vector2.zero;

            if (touch.position.x > screenHalf)
            {
                movement = Vector2.right;
            }
            else
            {
                movement = Vector2.left;
            }

            this.transform.position += movement * this.moveSpeed * Time.deltaTime;
        }
    }
}
