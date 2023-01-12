using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class orbit : MonoBehaviour
{
    public GameObject target;
    public float speed = 10;
    public Vector3 direction = Vector3.right;

    
    void Update()
    {
    transform.RotateAround(target.transform.position, direction, speed * Time.deltaTime);
            
    }
    
}
