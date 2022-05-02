using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chompScript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 20f;

    public GameObject scoreText;
    TextMesh theScoreTextMesh;


    void Awake()
    {
        this.theScoreTextMesh = this.scoreText.GetComponent<TextMesh>();
    }
    
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        this.theScoreTextMesh.text = "WOOT";
    }

    
    void Update()
    {
        if (Input.GetKeyDown("up"))
       {
           this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.up);
           rb.velocity = Vector3.forward * speed;
       }
       else if (Input.GetKeyDown("down"))
       {
           this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.up);
           rb.velocity = Vector3.back * speed;
       }
       else if (Input.GetKeyDown("left"))
       {
           this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.right);
           rb.velocity = Vector3.left * speed;
       }
       else if (Input.GetKeyDown("right"))
       {
           this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.right);
           rb.velocity = Vector3.right * speed;
       }
       else if (Input.GetKeyDown("space"))
       {
           rb.velocity = Vector3.up * speed;
       }
    }
}
