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
    private bool moveDown;
    private bool moveUp;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    private float verticalMove;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
        moveDown = false;
        moveUp = false;
        moveLeft = false;
        moveRight = false;
    }

    
    public void PointerDownLeft()
    {
        moveLeft = true;
    }
    public void PointerUpLeft()
    {
        moveLeft=false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight=false;
    }
    public void PointerDownUp()
    {
        moveUp = true;
    }
    public void PointerUpUp()
    {
        moveUp=false;
    }

    public void PointerDownDown()
    {
        moveDown = true;
    }

    public void PointerUpDown()
    {
        moveDown = false;
    }

    public void movePlayer()
    {
        if (moveLeft)
        {
            horizontalMove -= speed; 
        }
        else if (moveRight)
        {
            horizontalMove += speed;
        }
        else
        {
            horizontalMove = 0;
        }

       
        
        if (moveRight)
        {
            horizontalMove += speed;
        }
        else if (moveRight)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
      
        
        
        if (moveUp)
        {
            verticalMove -= speed;
        }
        else if (moveUp)
        {
            verticalMove = speed;
        }
        else
        {
            verticalMove = 0;
        }
       
        
        
        if (moveLeft)
        {
            verticalMove += speed;
        }
        else if (moveRight)
        {
            verticalMove = speed;
        }
        else
        {
            verticalMove = 0;
        }


    }









    private void Update()
    {
        //temp.x = Joystick.Horizontal;
        //temp.y = Joystick.Vertical;
        movePlayer();
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

        //Vector2 direction = Vector2.up * Joystick.Vertical + Vector2.right * Joystick.Horizontal;

       
        
        //    gameObject.transform.Translate(direction * speed * Time.deltaTime);
        
        player.velocity = new Vector2(horizontalMove, player.velocity.y);
        player.velocity = new Vector2(verticalMove, player.velocity.x);

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
