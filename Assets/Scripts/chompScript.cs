using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chompScript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 20f;

    
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown("up"))
       {
           
           rb.velocity = Vector3.forward * speed;
       }
       else if (Input.GetKeyDown("down"))
       {
           
           rb.velocity = Vector3.back * speed;
       }
       else if (Input.GetKeyDown("left"))
       {
           
           rb.velocity = Vector3.left * speed;
       }
       else if (Input.GetKeyDown("right"))
       {
           
           rb.velocity = Vector3.right * speed;
       }
       else if (Input.GetKeyDown("space"))
       {
           rb.velocity = Vector3.up * speed;
       }
    }
}
