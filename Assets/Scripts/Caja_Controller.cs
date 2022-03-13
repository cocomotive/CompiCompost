using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Caja_Controller : MonoBehaviour
{
    public string tipo_caja;
    public GameObject good;
    public GameObject bad;
    public GameObject envio;
    private GameObject feedback;
    public int Caja_Capacity = 5;
    private UnityEngine.Object explosionRef;
    private Material whiteMat;
    private Material defaultMat;
    SpriteRenderer sR;
    Image Ig;
    Animator Anim;
    public GameObject Game_Controller;

    // Start is called before the first frame update
    void Start()
    {
      Caja_Capacity = 0;
      Anim = GetComponent<Animator>();
      // Ig = GetComponent<Image>();
      // defaultMat = Ig.material;
      // whiteMat = Resources.Load("whiteFlash", typeof(Material)) as Material;
      

      
       //explosionRef = Resources.Load("Explosion");
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
            Game_Controller.GetComponent<Game_Controller>().AddScore(100);
            feedback = good;
            explosionRef = Resources.Load("Explosion");
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            StartCoroutine(FeedbackInactive());

         } else {
            Debug.Log("Mala");
            Game_Controller.GetComponent<Game_Controller>().AddScore(-100);
            feedback = bad;
            Anim.Play("Caja_Animation1");
            StartCoroutine(FeedbackInactive());


            // Ig.material = whiteMat;
            // if (Ig.material = whiteMat)
            // {
            //    Invoke("resetMat", 0.1f);
            // }
   
            //explosionRef = Resources.Load("ExplosionB");
            //GameObject explosion = (GameObject)Instantiate(explosionRef);
            //explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            
         }

    }

    //Activa el feedback
    private IEnumerator FeedbackInactive()
     { 
        feedback.SetActive(true);
        if (Caja_Capacity < 5)
        {
        yield return new WaitForSeconds(0.5f);
        feedback.SetActive(false);
        }

     }

      // private IEnumerator resetMat()
      // {
      //    Ig.material = defaultMat;
      //    yield return new WaitForSeconds(0.1f);

      
      // }






     public void Vaciar()
     {
        if (Caja_Capacity > 4){
        feedback.SetActive(false);
        envio.SetActive (true);
        Caja_Capacity = 0;
        }
        
     }




}
