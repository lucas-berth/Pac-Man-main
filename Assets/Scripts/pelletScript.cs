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
            Invoke("setBool", 3f);
            print("kill switch off");
        }
        */
       
    }

    // Update is called once per frame
    void Update()
    {
        if(chompkillswitch == true)
        {
            StartCoroutine(setBool());
        }
    }

    private IEnumerator setBool()
    {
        yield return new WaitForSeconds(10f);
        chompkillswitch = false;
        print("kill switch off");

    }
    
   
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            coreScript.score++;
            chompkillswitch = true;
            print("kill switch on");
            //StartCoroutine(setBool());
            Destroy(this.gameObject);
        }
    }

    
    // Start is called before the first frame update
    

    

    
}
