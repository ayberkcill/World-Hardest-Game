using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed = 4;

    [SerializeField]
    public bool moveleft;

    private void Update()
    {
        if (moveleft == true)
        {
            Vector2 temp = transform.position;
            temp.x += -enemySpeed * Time.deltaTime;
            transform.position = temp;
            Debug.Log("geldiii");
        }
        else
        {
            Vector2 temp = transform.position;
            temp.x += enemySpeed * Time.deltaTime;
            transform.position = temp;
            Debug.Log("else geldi");
        }
    }
    public void OnCollisionEnter2D(Collision2D target)
    {
      
        moveleft = !moveleft;
        Debug.Log("geldi");
        
    }
    
    
}
