using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ghostScript : MonoBehaviour
{
    Rigidbody rb;
    public GameObject thePlayer;
    NavMeshAgent theGhost;
    public float speed = 20.0f;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            if(pelletScript.chompkillswitch == true)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Destroy(thePlayer);
                print("GAME OVER");
            }
            
        }
    }


    void Awake()
    {
        //rb = this.gameObject.GetComponent<Rigidbody>();
        theGhost = this.gameObject.GetComponent<NavMeshAgent>();
        theGhost.speed = 2.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theGhost.SetDestination(thePlayer.gameObject.transform.position);
    }
}
