using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    public int coinValue = 0;   
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
        if(collision.tag == "enemy1")
        {
            SceneManager.LoadScene(0);
        }
        if (collision.tag == "enemy2")
        {
            SceneManager.LoadScene(1);
        }
        if (collision.tag == "enemy3")
        {
            SceneManager.LoadScene(2);
        }
        if (collision.tag == "enemy4")
        {
            SceneManager.LoadScene(3);
        }
        if (collision.tag == "enemy5")
        {
            SceneManager.LoadScene(4);
        }

        if (collision.tag == "go2")
        {
            SceneManager.LoadScene(1);
        }
        if (collision.tag == "go3")
        {
            SceneManager.LoadScene(2);
        }
        if (collision.tag == "go4" && coinValue == 9)
        {
            SceneManager.LoadScene(3);
        }
        if (collision.tag == "go5" && coinValue == 13)
        {
            SceneManager.LoadScene(4);
        }
        if(collision.tag == "coin")
        {
            coinValue++;
            Destroy(collision.gameObject);
        }
    }
}
