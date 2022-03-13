using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Residuo_Controller : MonoBehaviour
{
    public string tipo_item;
    public int speed;
    private Rigidbody2D myRB;

    //Para Audio:
    public AudioClip Click;
    AudioSource SoundPlayer;


        void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();   
    }

    // Start is called before the first frame update
    void Start()
    {
        SoundPlayer = GetComponent<AudioSource>();
        myRB = GetComponent<Rigidbody2D>();
        //InvokeRepeating("DestroyItem", 2f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        myRB.velocity = new Vector2(speed, myRB.velocity.y);
        
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

    }

    public void DestroyItem()
    {   
        if (myRB.gravityScale < 20f)
         {
         Destroy(gameObject);
         }

    }


}
