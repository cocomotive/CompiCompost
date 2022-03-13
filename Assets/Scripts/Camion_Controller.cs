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
            Game_Controller.GetComponent<Game_Controller>().AddScore(1000);
            feedback = good;
            feedback.SetActive(true);
            //StartCoroutine(FeedbackInactive());
           
         } else {
            Debug.Log("Mal Feedback en el camion!");
            feedback = bad;
            Game_Controller.GetComponent<Game_Controller>().AddScore(-1000);
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
