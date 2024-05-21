using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Markmovement : MonoBehaviour
{
    
    private float speed = 1f;  
    private Vector3 startposition;  

    void Start()
    {
        startposition = transform.position;
    }

    
    
    void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
        
        if (transform.position.x < -0.1)
        {
            
            transform.position = startposition;
        }
    }
}
