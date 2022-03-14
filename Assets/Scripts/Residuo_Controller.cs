using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Residuo_Controller : MonoBehaviour
{
    public string tipo_item;
    public float speed;
    private Rigidbody2D myRB;

    //Para Audio:
    public AudioClip Click;
    AudioSource SoundPlayer;
    public GameObject Feedback_malo;
    public GameObject Timer;
    public GameObject Residuos_Generator;




        void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();   
    }

    // Start is called before the first frame update
    void Start()
    {
        Timer = GameObject.FindGameObjectWithTag ("Canvas");
        SoundPlayer = GetComponent<AudioSource>();
        myRB = GetComponent<Rigidbody2D>();
        //Residuos_Generator = GameObject.FindGameObjectWithTag ("Residuos_Generator");
        //InvokeRepeating("DestroyItem", 2f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {

         myRB.velocity = new Vector2(speed, myRB.velocity.y);
  /*        if (Residuos_Generator.GetComponent<Residuos_Generator>().items_pasando > 3 && Residuos_Generator.GetComponent<Residuos_Generator>().items_pasando < 6 )
         {
             speed = 250;
         } else if(Residuos_Generator.GetComponent<Residuos_Generator>().items_pasando > 6)
         {
            speed = 400;
         } */   
    }


    public void Caer()
     {
        SoundPlayer.PlayOneShot(Click);
        myRB.constraints = RigidbodyConstraints2D.FreezePositionX;
        myRB.gravityScale = 60f;
     }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Caja1" || collision.gameObject.tag == "Caja2" || collision.gameObject.tag == "Caja3" )
         {
             Destroy(gameObject);
         }
         else if (collision.gameObject.tag == "Collider_Para_Compi")
         {
            myRB.gravityScale = 60f;
         }
         else
         {
            Timer.GetComponent<Timer>().AddTime(-10);
            transform.position = new Vector3 (0, 0, 0);
            GameObject Item = Instantiate(Feedback_malo, transform.position, transform.rotation) as GameObject;
            Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas_2").transform, false);
            Destroy(gameObject);
            
         }

    }

    public void DestroyItem()
    {   
        if (myRB.gravityScale < 20f)
         {
         Destroy(gameObject);
         }

    }


}
