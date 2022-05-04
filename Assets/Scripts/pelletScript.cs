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

    public static bool chompkillswitch = false;

    //int count = 0;


    void Awake()
    {
        this.theScoreTextMesh = this.scoreText.GetComponent<TextMesh>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {
        /*
        if(chompkillswitch == true)
        {
            Invoke("setBool", 3);
            print("kill switch off");
        }
        */
       
    }

    // Update is called once per frame
    void Update()
    {
        //this.theScoreTextMesh.text = "Score: " + count.ToString();
    }

    private IEnumerator setBool()
    {
        print("this is working");
        yield return new WaitForSeconds(3);
        chompkillswitch = false;
        print("kill switch off");

    }

    void otherSetBool()
    {
        print("this is working");
        chompkillswitch = false;
        print("kill switch off");
    }

    
    //the score updates once but never again... does not make sense
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            coreScript.score++;
            chompkillswitch = true;
            print("kill switch on");
            Invoke("otherSetBool", 3);
            //StartCoroutine(setBool());
            Destroy(this.gameObject);
            Invoke("otherSetBool", 3.0f);
        }
    }

    
    // Start is called before the first frame update
    

    

    
}
