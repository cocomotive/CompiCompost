using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Controller : MonoBehaviour
{
    public string tipo_item;
    private Rigidbody2D myRB;

        void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();   
    }

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        InvokeRepeating("DestroyItem", 2f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Caer()
     {
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
