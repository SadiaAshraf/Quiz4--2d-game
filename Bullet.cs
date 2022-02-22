using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public int score;
    void Start()
    {
      //LiveScores = gameObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
           
        //}
        transform.Translate(Vector2.up * Time.deltaTime * 12);
    }

    private void OnTriggerEnter(Collider other)
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log("Triggered");
            Destroy(collision.gameObject);
            Destroy(gameObject);
           
    }
}
