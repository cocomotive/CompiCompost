using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBoxMov : MonoBehaviour
{
    private Rigidbody2D myRB;
    public int speed;


    void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        myRB.velocity = new Vector2(myRB.velocity.x, speed);
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Debug.Log("entro trigger");
            myRB.constraints = RigidbodyConstraints2D.FreezePositionY;
            myRB.velocity = new Vector2(speed, myRB.velocity.y);
        }

        if (collision.gameObject.layer == 10)
        {
            myRB.constraints = RigidbodyConstraints2D.FreezePositionX;
            myRB.velocity = new Vector2(myRB.velocity.x, -speed);
        }

        if (collision.gameObject.layer == 11)
        {
            myRB.constraints = RigidbodyConstraints2D.FreezePositionY;
            myRB.velocity = new Vector2(-speed, myRB.velocity.y);
        }

        if (collision.gameObject.layer == 12)
        {
            myRB.constraints = RigidbodyConstraints2D.FreezePositionX;
            myRB.velocity = new Vector2(myRB.velocity.x, speed);
        }
    }
    
}
