using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelletScript : MonoBehaviour
{
    private Rigidbody rb;
    //public GameObject pellet;
    public GameObject thePlayer;
    

    public GameObject scoreText;
    TextMesh theScoreTextMesh;

    int count = 0;


    void Awake()
    {
        this.theScoreTextMesh = this.scoreText.GetComponent<TextMesh>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        //this.theScoreTextMesh.text = "Score: " + count.ToString();
    }



    
    //the score updates once but never again... does not make sense
    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            count++;
            this.theScoreTextMesh.text = "Score: " + count;
            
        }
        
    }

    
    // Start is called before the first frame update
    

    

    
}
