using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawn : MonoBehaviour
{
    
    float maxhojd = 1.75f;
    float minhojd = 1.0f;
    
    public GameObject rörprefab;
    GameObject rör;

    

    void Start()
    {
        InvokeRepeating("skapapipe", 2.0f, 2.0f);
    }

    void Update()
    {

    }

    void skapapipe()
    {
        
            
            Vector3 randomizeposition = new Vector3(2, Random.Range(minhojd, maxhojd), 0);

            Quaternion norotation = Quaternion.Euler(0,0,0);

            rör = Instantiate(rörprefab, randomizeposition, norotation);
            
    } 

   


}
