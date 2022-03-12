using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja_Controller : MonoBehaviour
{
    public string tipo_caja;
    public GameObject good;
    public GameObject bad;
    public GameObject envio;
    private GameObject feedback;
    public int Caja_Capacity = 5;



    // Start is called before the first frame update
    void Start()
    {
       Caja_Capacity = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Item"+tipo_caja || collision.gameObject.tag == "Item"+tipo_caja+"_Cinta")
         {
            Caja_Capacity = Caja_Capacity +1;
            Debug.Log("Buena");
            feedback = good;
            StartCoroutine(FeedbackInactive());

         } else {
            Debug.Log("Mala");
            feedback = bad;
            StartCoroutine(FeedbackInactive());
         }

    }

    //Activa el feedback
    private IEnumerator FeedbackInactive()
     { 
        feedback.SetActive(true);
        if (Caja_Capacity < 5)
        {
        yield return new WaitForSeconds(0.3f);
        feedback.SetActive(false);
        }

     }


     public void Vaciar()
     {
        if (Caja_Capacity > 4){
        feedback.SetActive(false);
        envio.SetActive (true);
        Caja_Capacity = 0;
        }
        
     }




}
