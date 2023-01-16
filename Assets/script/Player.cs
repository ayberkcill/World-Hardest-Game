using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    public int coinValue = 0;
    public FloatingJoystick Joystick;
    Rigidbody2D player;
    Vector2 temp;
    public bool PointerDown;
    

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //temp.x = Joystick.Horizontal;
        //temp.y = Joystick.Vertical;
    }

    private void FixedUpdate()
    {
        //Vector2 temp = transform.position;

        //if (Input.GetKey(KeyCode.D))
        //{
        //    temp.x += speed * Time.deltaTime;
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    temp.x -= speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    temp.y += speed * Time.deltaTime;
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    temp.y -= speed * Time.deltaTime;
        //}

        //if (PointerDown)
        //{
        //    rb.position = Vector3.zero;
        //}

        //else
        //{
        //transform.position = temp;

        //rb.MovePosition(rb.position * temp * speed * Time.fixedDeltaTime);
        //}

        Vector2 direction = Vector2.up * Joystick.Vertical + Vector2.right * Joystick.Horizontal;

       
        
            gameObject.transform.Translate(direction * speed * Time.deltaTime);
        


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
