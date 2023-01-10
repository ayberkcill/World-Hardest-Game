using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed = 4f;

    [SerializeField]
    private bool moveleft;
    void Update()
    {
        if (moveleft)
        {
            Vector3 temp = transform.position;
            temp.x -= enemySpeed * Time.deltaTime;
            transform.position = temp;  
        }
        else
        {
            Vector3 temp = transform.position;
            temp.x += enemySpeed * Time.deltaTime;  
            transform.position = temp;  
        }

        




    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "collider")
        {
            moveleft = !moveleft;
        }
    }
}
