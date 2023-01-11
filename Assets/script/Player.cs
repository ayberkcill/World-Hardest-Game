using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            SceneManager.LoadScene(0);
        }
    }
}
