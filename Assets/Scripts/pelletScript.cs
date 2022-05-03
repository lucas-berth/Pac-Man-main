using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelletScript : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject pellet;
    private int count;

    void OnCollisionEnter(Collision collision)
    {
        print("this is working");
        if(collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            count++;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
       rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public int getScore()
    {
        return count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
