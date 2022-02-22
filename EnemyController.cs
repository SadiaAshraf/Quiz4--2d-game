using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }   

    //private void OnTriggerEnter(Collider other)
    //{
        
    //}
    //public void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(gameObject);
    //    Debug.Log("collision");
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Debug.Log("collision 2d");
    }
}

