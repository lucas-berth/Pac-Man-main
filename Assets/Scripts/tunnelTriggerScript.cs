using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunnelTriggerScript : MonoBehaviour
{

    void Awake()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        if(this.tag.Equals("cubeRight"))
        {
            if(collision.gameObject.tag.Equals("Player"))
            {
                print("spawning left");
            }
        }
        else if(this.tag.Equals("cubeLeft"))
        {
            if(collision.gameObject.tag.Equals("Player"))
            {
                print("spawning right");
            }
        }
        
    }




    void Update()
    {


    }
}
