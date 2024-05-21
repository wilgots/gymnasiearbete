using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovement : MonoBehaviour
{
        // Hastigheten som röret rör sig med
    private float hastighet = 1f;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        //flytta rör åt vänster.
        transform.Translate(Vector3.left * hastighet * Time.deltaTime);
    }

    
}
