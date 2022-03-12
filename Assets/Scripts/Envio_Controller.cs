using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envio_Controller : MonoBehaviour
{
    public string tipo_envio;
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }



     private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Camion"+tipo_envio )
         {
            Debug.Log("Buen envio!");
            transform.position = originalPosition;
            gameObject.SetActive(false);
            //Destroy(gameObject);
         }
         else
         {
            Debug.Log("Mal envio!");
            transform.position = originalPosition;
            gameObject.SetActive(false);
            //Destroy(gameObject);

         }

    }



}
