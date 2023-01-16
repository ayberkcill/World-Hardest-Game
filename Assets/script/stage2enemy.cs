using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2enemy : MonoBehaviour
{
    public float enemySpeed = 4;

    [SerializeField]
    public bool moveup;

    private void Update()
    {
        if (moveup == true)
        {
            Vector2 temp = transform.position;
            temp.y += -enemySpeed * Time.deltaTime;
            transform.position = temp;
            Debug.Log("geldiii");
        }
        else
        {
            Vector2 temp = transform.position;
            temp.y += enemySpeed * Time.deltaTime;
            transform.position = temp;
            Debug.Log("else geldi");
        }
    }
    public void OnCollisionEnter2D(Collision2D target)
    {

        moveup = !moveup;
        Debug.Log("geldi");

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemycol")
        {
            moveup = !moveup;
        }    
    }
}
