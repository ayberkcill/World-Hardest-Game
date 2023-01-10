using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    
    void FixedUpdate()
    {
        Vector2 temp = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            temp.x += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            temp.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            temp.y += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            temp.y -= speed * Time.deltaTime;
        }
        transform.position = temp;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
