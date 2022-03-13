using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camion_Controller : MonoBehaviour
{
    public string camion_tipo;
    public GameObject good;
    public GameObject bad;
    private GameObject feedback;
    public GameObject Game_Controller;
    private UnityEngine.Object explosionRef;
    public bool movement;
    private Rigidbody2D myRB;
    public int speed;
    public Vector3 originalPosition;

    void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();   
    }  

    // Start is called before the first frame update
    void Start()
    {
       originalPosition = transform.position;      
    }

    // Update is called once per frame
    void Update()
    {
       if (movement == true)
       {
          myRB.velocity = new Vector2(speed, myRB.velocity.y);
       } else
       {
          myRB.velocity = new Vector2(0, myRB.velocity.y);
       }

    }


    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Envio"+camion_tipo)
         {
            Debug.Log("Buen Feedback en el camion!");
            Game_Controller.GetComponent<Game_Controller>().AddScore(1000);
            movement = true;
            feedback = good;
            feedback.SetActive(true);
            

            explosionRef = Resources.Load("Explosion");
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            StartCoroutine(FeedbackInactive());

            //StartCoroutine(FeedbackInactive());
           
         } else {
            //Debug.Log("Mal Feedback en el camion!");
            //feedback = bad;
            //Game_Controller.GetComponent<Game_Controller>().AddScore(-1000);
            //StartCoroutine(FeedbackInactive());
         }

    }



    private IEnumerator FeedbackInactive()
     { 
        feedback.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        feedback.SetActive(false);
        StartCoroutine(ResetPosition());
        
     }

      private IEnumerator ResetPosition()
     { 
        
        yield return new WaitForSeconds(3f);
        movement = false;
        feedback.SetActive(false);
        transform.position = originalPosition;
        
        
     }




}
