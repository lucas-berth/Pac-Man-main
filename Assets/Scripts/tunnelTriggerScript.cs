using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunnelTriggerScript : MonoBehaviour
{

    public Transform spawnPointLeft;
    public Transform spawnPointRight;
    public GameObject thePlayer;


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
                thePlayer.transform.position = spawnPointLeft.position;
            }
        }
        else if(this.tag.Equals("cubeLeft"))
        {
            if(collision.gameObject.tag.Equals("Player"))
            {
                print("spawning right");
                thePlayer.transform.position = spawnPointRight.position;
            }
        }
        
    }





    void Update()
    {


    }
}
