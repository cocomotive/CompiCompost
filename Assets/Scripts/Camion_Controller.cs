using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion_Controller : MonoBehaviour
{
    public string camion_tipo;
    public GameObject good;
    public GameObject bad;
    private GameObject feedback;
 


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Envio"+camion_tipo)
         {
            Debug.Log("Buen Feedback en el camion!");
            feedback = good;
            feedback.SetActive(true);
            //StartCoroutine(FeedbackInactive());
           

         } else {
            Debug.Log("Mal Feedback en el camion!");
            feedback = bad;
            StartCoroutine(FeedbackInactive());
         }

    }



    private IEnumerator FeedbackInactive()
     { 
        feedback.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        feedback.SetActive(false);
        
     }




}
